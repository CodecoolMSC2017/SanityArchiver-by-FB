namespace SanityArchiver
{
    partial class RenameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameForm));
            this.OldName = new System.Windows.Forms.TextBox();
            this.RenameButton = new System.Windows.Forms.Button();
            this.NewName = new System.Windows.Forms.TextBox();
            this.OldNameLabel1 = new System.Windows.Forms.Label();
            this.NewNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OldName
            // 
            this.OldName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OldName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OldName.Enabled = false;
            this.OldName.Location = new System.Drawing.Point(106, 53);
            this.OldName.Name = "OldName";
            this.OldName.Size = new System.Drawing.Size(236, 20);
            this.OldName.TabIndex = 3;
            // 
            // RenameButton
            // 
            this.RenameButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RenameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RenameButton.Location = new System.Drawing.Point(164, 195);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(128, 32);
            this.RenameButton.TabIndex = 17;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = false;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // NewName
            // 
            this.NewName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewName.Location = new System.Drawing.Point(106, 145);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(236, 20);
            this.NewName.TabIndex = 18;
            // 
            // OldNameLabel1
            // 
            this.OldNameLabel1.AutoSize = true;
            this.OldNameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.OldNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OldNameLabel1.Location = new System.Drawing.Point(190, 34);
            this.OldNameLabel1.Name = "OldNameLabel1";
            this.OldNameLabel1.Size = new System.Drawing.Size(81, 16);
            this.OldNameLabel1.TabIndex = 19;
            this.OldNameLabel1.Text = "Old Name:";
            // 
            // NewNameLabel
            // 
            this.NewNameLabel.AutoSize = true;
            this.NewNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewNameLabel.Location = new System.Drawing.Point(188, 126);
            this.NewNameLabel.Name = "NewNameLabel";
            this.NewNameLabel.Size = new System.Drawing.Size(83, 16);
            this.NewNameLabel.TabIndex = 20;
            this.NewNameLabel.Text = "New Name";
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(425, 251);
            this.Controls.Add(this.NewNameLabel);
            this.Controls.Add(this.OldNameLabel1);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.OldName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RenameForm";
            this.Text = "Sanity Archiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OldName;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.Label OldNameLabel1;
        private System.Windows.Forms.Label NewNameLabel;
    }
}