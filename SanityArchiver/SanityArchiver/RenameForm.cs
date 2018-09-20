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

namespace SanityArchiver
{
    public partial class RenameForm : Form
    {
        public string newName;
        public Form1 form1;
        public ListView liv;
        public RenameForm(FileInfo selectedFile, string newName,Form1 form1, ListView liv)
        {
            InitializeComponent();
            this.form1 = form1;
            this.liv = liv;
            OldName.Text = selectedFile.Name;
            newName = selectedFile.Name;
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            if(NewName.Text == "")
            {
                MessageBox.Show("Please enter a new name!", "Error");
                return;
            }
            newName = NewName.Text;
            form1.Rename(newName,liv);
            Hide();
        }
    }
}
