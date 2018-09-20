using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO.Compression;

namespace SanityArchiver
{
    public partial class Form1 : Form
    {
        private String DirectoryPath1;
        private String DirectoryPath2;
        private FileInfo selectedFile;


        public Form1()
        {
            InitializeComponent();
            CreateListView(Directory1);
            CreateListView(Directory2);
        }

        private void Change1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Path1.Text = fbd.SelectedPath;
                    DirectoryPath1 = fbd.SelectedPath;
                    PopulateListView(Directory1, fbd.SelectedPath);
                }
            }
        }

        private void Change2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Path2.Text = fbd.SelectedPath;
                    DirectoryPath2 = fbd.SelectedPath;
                    PopulateListView(Directory2, fbd.SelectedPath);

                }
            }
        }

        private void Path1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (Directory.Exists(Path1.Text))
                {
                    DirectoryPath1 = Path1.Text;
                    PopulateListView(Directory1, DirectoryPath1);

                }
                else
                {
                    Path1.Text = DirectoryPath1;
                    MessageBox.Show("Directory doesn't exists!", "Error");
                }
            }
        }

        private void Path2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (Directory.Exists(Path2.Text))
                {
                    DirectoryPath2 = Path2.Text;
                    PopulateListView(Directory2, DirectoryPath2);
                }
                else
                {
                    Path2.Text = DirectoryPath2;
                    MessageBox.Show("Directory doesn't exists!", "Error");
                }
            }
        }


        private void Directory2_Click(object sender, EventArgs e)
        {
            ClickHandler(Directory2, ref DirectoryPath2);

        }

        private void Directory1_Click(object sender, EventArgs e)
        {
            ClickHandler(Directory1, ref DirectoryPath1);
        }


        private void Directory1_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickHandler(Directory1, ref DirectoryPath1);
        }

        private void Directory2_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickHandler(Directory2, ref DirectoryPath2);
        }


        private void CreateListView(ListView liv)
        {
            liv.View = View.Details;

            liv.Columns.Add("Type");
            liv.Columns.Add("Name");
            liv.Columns.Add("Size");


            liv.GridLines = true;
            liv.FullRowSelect = true;
            liv.Columns[0].Width = 80;
            liv.Columns[1].Width = 300;
            liv.Columns[2].Width = 80;
        }

        private void PopulateListView(ListView lsv, string Folder)
        {
            lsv.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            DirectoryInfo[] directories = dinfo.GetDirectories();

            //Add parent dict
            lsv.Items.Add(new ListViewItem(new string[] { "Parent", dinfo.Parent.Name, "..." }));

            //Add directories
            foreach (DirectoryInfo dir in directories)
            {
                long size = EvaluateSize(dir);
                string dirSize = EvaluateSize(size);
                lsv.Items.Add(new ListViewItem(new string[] { "Directory", dir.Name, dirSize }));
            }

            FileInfo[] Files = dinfo.GetFiles();

            //Add files
            foreach (FileInfo file in Files)
            {
                if (file.Name.Equals("desktop.ini"))
                {
                    continue;
                }
                string fileSize = EvaluateSize(file.Length);
                lsv.Items.Add(new ListViewItem(new string[] { "File", file.Name, fileSize }));
            }
        }

        private long EvaluateSize(DirectoryInfo root)
        {
            return Directory.GetFiles(root.FullName, "*", SearchOption.AllDirectories).Sum(t => (new FileInfo(t).Length));
        }

        private string EvaluateSize(long size)
        {
            if (size < 1024)
            {
                return size + " bytes";
            }
            else if (size > 1024 && size < 1048576)
            {
                return (size / 1024).ToString("#.##") + " kb";
            }
            else
            {
                return (size / 1048576).ToString("#.##") + " mb";
            }
        }

        private void DoubleClickHandler(ListView liv, ref string path)
        {
            var firstSelectedItem = liv.SelectedItems[0];
            string type = firstSelectedItem.SubItems[0].Text;
            DirectoryInfo dinfo = new DirectoryInfo(path);
            if (type.Equals("Directory"))
            {
                DirectoryInfo[] directories = dinfo.GetDirectories();
                foreach (DirectoryInfo dir in directories)
                {
                    if (dir.Name.Equals(firstSelectedItem.SubItems[1].Text))
                    {
                        path = dir.FullName;
                        Path1.Text = path;
                        PopulateListView(liv, path);
                    }
                }
            }
            else if (type.Equals("Parent"))
            {
                DirectoryInfo parent = dinfo.Parent;
                path = parent.FullName;
                Path1.Text = path;
                PopulateListView(liv, path);
            }
        }

        private void ClickHandler(ListView liv, ref string path)
        {
            var firstSelectedItem = liv.SelectedItems[0];
            string type = firstSelectedItem.SubItems[0].Text;
            var fileName = firstSelectedItem.SubItems[1].Text;
            DirectoryInfo dinfo = new DirectoryInfo(path);
            if (type.Equals("File"))
            {
                selectedFile = dinfo.GetFiles(fileName)[0];
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (!CheckErrors())
            {
                return;
            }
            if (selectedFile.Directory.FullName.Equals(DirectoryPath1))
            {
                Copy(DirectoryPath2, Directory2);
            }
            else if (selectedFile.Directory.FullName.Equals(DirectoryPath2))
            {
                Copy(DirectoryPath1, Directory1);
            }
        }

        private void Copy(string destinationDirectory, ListView liv)
        {
            string destination = destinationDirectory + @"\" + selectedFile.Name;
            File.Copy(selectedFile.FullName, destination, true);
            PopulateListView(liv, destinationDirectory);
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            if (!CheckErrors())
            {
                return;
            }
            if (selectedFile.Directory.FullName.Equals(DirectoryPath1))
            {
                MoveFile(DirectoryPath2);
            }
            else if (selectedFile.Directory.FullName.Equals(DirectoryPath2))
            {
                MoveFile(DirectoryPath1);
            }
        }

        private void MoveFile(string destinationDirectory)
        {
            string destination = destinationDirectory + @"\" + selectedFile.Name;
            if (File.Exists(destination))
            {
                File.Delete(destination);
            }
            File.Move(selectedFile.FullName, destination);
            PopulateListView(Directory1, DirectoryPath1);
            PopulateListView(Directory2, DirectoryPath2);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!CheckErrors())
            {
                return;
            }
            if (selectedFile.Directory.FullName.Equals(DirectoryPath1))
            {
                DeleteFile(selectedFile.FullName, Directory2);
            }
            else if (selectedFile.Directory.FullName.Equals(DirectoryPath2))
            {
                DeleteFile(selectedFile.FullName, Directory2);
            }
        }

        private void DeleteFile(string path, ListView liv)
        {

            try
            {
                File.SetAttributes(path, FileAttributes.Normal);
                File.Delete(path);
            }
            catch (IOException)
            {

            }
            PopulateListView(liv, path);
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (!CheckErrors())
            {
                return;
            }

            if (selectedFile.Directory.FullName.Equals(DirectoryPath1))
            {
                RenameFile(Directory1);
            }
            else if (selectedFile.Directory.FullName.Equals(DirectoryPath2))
            {
                RenameFile(Directory2);
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (!CheckErrors())
            {
                return;
            }

            if (selectedFile.Directory.FullName.Equals(DirectoryPath1))
            {
                EncrptFile(Directory1);
            }
            else if (selectedFile.Directory.FullName.Equals(DirectoryPath2))
            {
                EncrptFile(Directory2);
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (!CheckErrors())
            {
                return;
            }

            if (selectedFile.Directory.FullName.Equals(DirectoryPath1))
            {
                DecryptFile(Directory1);
            }
            else if (selectedFile.Directory.FullName.Equals(DirectoryPath2))
            {
                DecryptFile(Directory2);
            }
        }

        private void DecryptFile(ListView liv)
        {
            try
            {
                string password = @"myKey123"; // Your Key Here

                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string newName = selectedFile.Name;

                int resultIndex = selectedFile.Name.IndexOf("encrypted");
                if (resultIndex != -1)
                {
                    newName = selectedFile.Name.Substring(resultIndex+9);
                }

                string newFullName = selectedFile.Directory.FullName + @"\" + "decrypted" + newName;

                if (File.Exists(newFullName))
                {
                    File.SetAttributes(newFullName, FileAttributes.Normal);
                    File.Delete(newFullName);
                }


                FileStream fsCrypt = new FileStream(selectedFile.FullName, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(newFullName, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
                PopulateListView(liv, selectedFile.Directory.FullName);
            }
            catch
            {
                MessageBox.Show("Decryption failed!", "Error");
            }
        }

        private void EncrptFile(ListView liv)
        {
            try
            {
                File.SetAttributes(selectedFile.FullName, FileAttributes.Normal);
                string password = @"myKey123"; // Your Key Here
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string newName = selectedFile.Name;
                int resultIndex = selectedFile.Name.IndexOf("encrypted");
                if (resultIndex != -1)
                {
                    newName = selectedFile.Name.Substring(resultIndex + 9);
                }

                string newFullName = selectedFile.Directory.FullName + @"\" + "encrypted" + newName;


                if (File.Exists(newFullName))
                {
                    File.SetAttributes(newFullName, FileAttributes.Normal);
                    File.Delete(newFullName);
                }

                string cryptFile = newFullName;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(selectedFile.FullName, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();

                PopulateListView(liv, selectedFile.Directory.FullName);
            }
            catch
            {
                MessageBox.Show("Encryption failed!", "Error");
            }
        }


        private void RenameFile(ListView liv)
        {

            string newName = "";
            RenameForm renameForm = new RenameForm(selectedFile, newName, this,liv);
            newName = renameForm.newName;
            renameForm.ShowDialog();

        }

        public void Rename(string newName, ListView liv)
        {
            string newFullName = selectedFile.Directory.FullName + @"\" + newName;
            if (File.Exists(newFullName))
            {
                File.SetAttributes(newFullName, FileAttributes.Normal);
                File.Delete(newFullName);
            }

            File.Move(selectedFile.FullName, newFullName);
            PopulateListView(liv, selectedFile.Directory.FullName);
        }

        private bool CheckErrors()
        {
            if (selectedFile == null)
            {
                MessageBox.Show("Please select a file first!", "Error");
                return false;
            }
            if (DirectoryPath1 == null || DirectoryPath2 == null)
            {
                MessageBox.Show("Please select 2 directories first!", "Error");
                return false;
            }
            return true;
        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            if (!CheckErrors())
            {
                return;
            }

            if (selectedFile.Directory.FullName.Equals(DirectoryPath1))
            {
                CompressFile(Directory1);
            }
            else if (selectedFile.Directory.FullName.Equals(DirectoryPath2))
            {
                CompressFile(Directory2);
            }
        }


        private void CompressFile(ListView liv)
        {
            string fileToBeCompressed = selectedFile.FullName;

            string nameWithoutExtension = selectedFile.Name.Split('.')[0];
            string newFullName = selectedFile.Directory.FullName + @"\" + nameWithoutExtension + ".zip";
            string zipFilename = newFullName;
            


            using (ZipArchive archive = ZipFile.Open(newFullName, ZipArchiveMode.Update))
            {
                archive.CreateEntryFromFile(selectedFile.FullName,selectedFile.Name);
            }
            PopulateListView(liv, selectedFile.Directory.FullName);
        }

        private void DecompressButton_Click(object sender, EventArgs e)
        {
            if (!CheckErrors())
            {
                return;
            }

            if (selectedFile.Directory.FullName.Equals(DirectoryPath1))
            {
                DecompressFile(Directory1);
            }
            else if (selectedFile.Directory.FullName.Equals(DirectoryPath2))
            {
                DecompressFile(Directory2);
            }
        }

        private void DecompressFile(ListView liv)
        {
            string extension = selectedFile.Name.Split('.')[1];
            if (!extension.Equals("zip"))
            {
                MessageBox.Show("Please select a zip file!", "Error");
                return;
            }
            try
            {
                ZipFile.ExtractToDirectory(selectedFile.FullName, selectedFile.Directory.FullName);
            }
            catch (IOException)
            {
                MessageBox.Show("File already exists!", "Cannot unzip");
            }

        }

        private void AttributesButton_Click(object sender, EventArgs e)
        {
            if (!CheckErrors())
            {
                return;
            }

            File.SetAttributes(selectedFile.FullName, FileAttributes.ReadOnly);
        }


    }


}
