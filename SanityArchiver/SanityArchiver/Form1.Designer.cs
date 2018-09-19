namespace SanityArchiver
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Path1 = new System.Windows.Forms.TextBox();
            this.Path2 = new System.Windows.Forms.TextBox();
            this.PathLabel2 = new System.Windows.Forms.Label();
            this.PathLabel1 = new System.Windows.Forms.Label();
            this.Change1 = new System.Windows.Forms.Button();
            this.Change2 = new System.Windows.Forms.Button();
            this.Directory1 = new System.Windows.Forms.ListView();
            this.Directory2 = new System.Windows.Forms.ListView();
            this.CopyButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.CompressButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.DecompressButton = new System.Windows.Forms.Button();
            this.Pattern1 = new System.Windows.Forms.TextBox();
            this.Pattern2 = new System.Windows.Forms.TextBox();
            this.PatternLabel1 = new System.Windows.Forms.Label();
            this.PatternLabel2 = new System.Windows.Forms.Label();
            this.PatternSearchButton1 = new System.Windows.Forms.PictureBox();
            this.PatternSearchButton2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PatternSearchButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatternSearchButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // Path1
            // 
            this.Path1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Path1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Path1.Location = new System.Drawing.Point(66, 41);
            this.Path1.Name = "Path1";
            this.Path1.Size = new System.Drawing.Size(461, 20);
            this.Path1.TabIndex = 2;
            this.Path1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Path1_KeyDown);
            // 
            // Path2
            // 
            this.Path2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Path2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Path2.Location = new System.Drawing.Point(741, 41);
            this.Path2.Name = "Path2";
            this.Path2.Size = new System.Drawing.Size(461, 20);
            this.Path2.TabIndex = 3;
            this.Path2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Path2_KeyDown);
            // 
            // PathLabel2
            // 
            this.PathLabel2.AutoSize = true;
            this.PathLabel2.BackColor = System.Drawing.Color.Transparent;
            this.PathLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PathLabel2.Location = new System.Drawing.Point(685, 41);
            this.PathLabel2.Name = "PathLabel2";
            this.PathLabel2.Size = new System.Drawing.Size(50, 20);
            this.PathLabel2.TabIndex = 6;
            this.PathLabel2.Text = "Path :";
            // 
            // PathLabel1
            // 
            this.PathLabel1.AutoSize = true;
            this.PathLabel1.BackColor = System.Drawing.Color.Transparent;
            this.PathLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PathLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.PathLabel1.Location = new System.Drawing.Point(8, 41);
            this.PathLabel1.Name = "PathLabel1";
            this.PathLabel1.Size = new System.Drawing.Size(50, 20);
            this.PathLabel1.TabIndex = 7;
            this.PathLabel1.Text = "Path :";
            // 
            // Change1
            // 
            this.Change1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Change1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change1.FlatAppearance.BorderSize = 0;
            this.Change1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change1.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Change1.Location = new System.Drawing.Point(137, 500);
            this.Change1.Name = "Change1";
            this.Change1.Size = new System.Drawing.Size(296, 23);
            this.Change1.TabIndex = 8;
            this.Change1.Text = "Change Directory";
            this.Change1.UseVisualStyleBackColor = false;
            this.Change1.Click += new System.EventHandler(this.Change1_Click);
            // 
            // Change2
            // 
            this.Change2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Change2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change2.FlatAppearance.BorderSize = 0;
            this.Change2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change2.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Change2.Location = new System.Drawing.Point(840, 500);
            this.Change2.Name = "Change2";
            this.Change2.Size = new System.Drawing.Size(296, 23);
            this.Change2.TabIndex = 9;
            this.Change2.Text = "Change Directory";
            this.Change2.UseVisualStyleBackColor = false;
            this.Change2.Click += new System.EventHandler(this.Change2_Click);
            // 
            // Directory1
            // 
            this.Directory1.AllowColumnReorder = true;
            this.Directory1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Directory1.Location = new System.Drawing.Point(66, 81);
            this.Directory1.Name = "Directory1";
            this.Directory1.Size = new System.Drawing.Size(461, 413);
            this.Directory1.TabIndex = 10;
            this.Directory1.UseCompatibleStateImageBehavior = false;
            this.Directory1.Click += new System.EventHandler(this.Directory1_Click);
            this.Directory1.DoubleClick += new System.EventHandler(this.Directory1_DoubleClick);
            // 
            // Directory2
            // 
            this.Directory2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Directory2.Location = new System.Drawing.Point(741, 81);
            this.Directory2.Name = "Directory2";
            this.Directory2.Size = new System.Drawing.Size(461, 413);
            this.Directory2.TabIndex = 11;
            this.Directory2.UseCompatibleStateImageBehavior = false;
            this.Directory2.Click += new System.EventHandler(this.Directory2_Click);
            this.Directory2.DoubleClick += new System.EventHandler(this.Directory2_DoubleClick);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyButton.FlatAppearance.BorderSize = 0;
            this.CopyButton.Location = new System.Drawing.Point(580, 81);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(128, 32);
            this.CopyButton.TabIndex = 12;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EncryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptButton.Location = new System.Drawing.Point(580, 233);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(128, 32);
            this.EncryptButton.TabIndex = 13;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = false;
            // 
            // CompressButton
            // 
            this.CompressButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CompressButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompressButton.Location = new System.Drawing.Point(580, 309);
            this.CompressButton.Name = "CompressButton";
            this.CompressButton.Size = new System.Drawing.Size(128, 32);
            this.CompressButton.TabIndex = 14;
            this.CompressButton.Text = "Compress";
            this.CompressButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Location = new System.Drawing.Point(580, 157);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(128, 32);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // RenameButton
            // 
            this.RenameButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RenameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RenameButton.Location = new System.Drawing.Point(580, 195);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(128, 32);
            this.RenameButton.TabIndex = 16;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = false;
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DecryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptButton.Location = new System.Drawing.Point(580, 271);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(128, 32);
            this.DecryptButton.TabIndex = 17;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = false;
            // 
            // MoveButton
            // 
            this.MoveButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveButton.FlatAppearance.BorderSize = 0;
            this.MoveButton.Location = new System.Drawing.Point(580, 119);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(128, 32);
            this.MoveButton.TabIndex = 18;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = false;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // DecompressButton
            // 
            this.DecompressButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DecompressButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecompressButton.Location = new System.Drawing.Point(580, 347);
            this.DecompressButton.Name = "DecompressButton";
            this.DecompressButton.Size = new System.Drawing.Size(128, 32);
            this.DecompressButton.TabIndex = 19;
            this.DecompressButton.Text = "Decompress";
            this.DecompressButton.UseVisualStyleBackColor = false;
            // 
            // Pattern1
            // 
            this.Pattern1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Pattern1.Location = new System.Drawing.Point(83, 14);
            this.Pattern1.Name = "Pattern1";
            this.Pattern1.Size = new System.Drawing.Size(405, 20);
            this.Pattern1.TabIndex = 20;
            // 
            // Pattern2
            // 
            this.Pattern2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Pattern2.Location = new System.Drawing.Point(760, 12);
            this.Pattern2.Name = "Pattern2";
            this.Pattern2.Size = new System.Drawing.Size(403, 20);
            this.Pattern2.TabIndex = 21;
            // 
            // PatternLabel1
            // 
            this.PatternLabel1.AutoSize = true;
            this.PatternLabel1.BackColor = System.Drawing.Color.Transparent;
            this.PatternLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PatternLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PatternLabel1.Location = new System.Drawing.Point(8, 12);
            this.PatternLabel1.Name = "PatternLabel1";
            this.PatternLabel1.Size = new System.Drawing.Size(69, 20);
            this.PatternLabel1.TabIndex = 22;
            this.PatternLabel1.Text = "Pattern :";
            // 
            // PatternLabel2
            // 
            this.PatternLabel2.AutoSize = true;
            this.PatternLabel2.BackColor = System.Drawing.Color.Transparent;
            this.PatternLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PatternLabel2.Location = new System.Drawing.Point(685, 12);
            this.PatternLabel2.Name = "PatternLabel2";
            this.PatternLabel2.Size = new System.Drawing.Size(69, 20);
            this.PatternLabel2.TabIndex = 23;
            this.PatternLabel2.Text = "Pattern :";
            // 
            // PatternSearchButton1
            // 
            this.PatternSearchButton1.BackColor = System.Drawing.Color.Transparent;
            this.PatternSearchButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatternSearchButton1.Image = global::SanityArchiver.Properties.Resources.if_search_298865_1_;
            this.PatternSearchButton1.Location = new System.Drawing.Point(503, 14);
            this.PatternSearchButton1.Name = "PatternSearchButton1";
            this.PatternSearchButton1.Size = new System.Drawing.Size(24, 22);
            this.PatternSearchButton1.TabIndex = 24;
            this.PatternSearchButton1.TabStop = false;
            // 
            // PatternSearchButton2
            // 
            this.PatternSearchButton2.BackColor = System.Drawing.Color.Transparent;
            this.PatternSearchButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatternSearchButton2.Image = global::SanityArchiver.Properties.Resources.if_search_298865_1_;
            this.PatternSearchButton2.Location = new System.Drawing.Point(1178, 12);
            this.PatternSearchButton2.Name = "PatternSearchButton2";
            this.PatternSearchButton2.Size = new System.Drawing.Size(24, 22);
            this.PatternSearchButton2.TabIndex = 25;
            this.PatternSearchButton2.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1259, 540);
            this.Controls.Add(this.PatternSearchButton2);
            this.Controls.Add(this.PatternSearchButton1);
            this.Controls.Add(this.PatternLabel2);
            this.Controls.Add(this.PatternLabel1);
            this.Controls.Add(this.Pattern2);
            this.Controls.Add(this.Pattern1);
            this.Controls.Add(this.DecompressButton);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CompressButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.Directory2);
            this.Controls.Add(this.Directory1);
            this.Controls.Add(this.Change2);
            this.Controls.Add(this.Change1);
            this.Controls.Add(this.PathLabel1);
            this.Controls.Add(this.PathLabel2);
            this.Controls.Add(this.Path2);
            this.Controls.Add(this.Path1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Sanity Archiver";
            ((System.ComponentModel.ISupportInitialize)(this.PatternSearchButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatternSearchButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Path1;
        private System.Windows.Forms.TextBox Path2;
        private System.Windows.Forms.Label PathLabel2;
        private System.Windows.Forms.Label PathLabel1;
        private System.Windows.Forms.Button Change1;
        private System.Windows.Forms.Button Change2;
        private System.Windows.Forms.ListView Directory1;
        private System.Windows.Forms.ListView Directory2;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button CompressButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button DecompressButton;
        private System.Windows.Forms.TextBox Pattern1;
        private System.Windows.Forms.TextBox Pattern2;
        private System.Windows.Forms.Label PatternLabel1;
        private System.Windows.Forms.Label PatternLabel2;
        private System.Windows.Forms.PictureBox PatternSearchButton1;
        private System.Windows.Forms.PictureBox PatternSearchButton2;
    }
}

