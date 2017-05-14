namespace XcomPerkManager.Forms
{
    partial class ImportClasses
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
            this.bSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bUpdate = new System.Windows.Forms.Button();
            this.laDescription = new System.Windows.Forms.Label();
            this.tDescription = new System.Windows.Forms.TextBox();
            this.laDisplayName = new System.Windows.Forms.Label();
            this.tDisplayName = new System.Windows.Forms.TextBox();
            this.laInternalName = new System.Windows.Forms.Label();
            this.tInternalName = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.laFile = new System.Windows.Forms.Label();
            this.bImport = new System.Windows.Forms.Button();
            this.bBrowse = new System.Windows.Forms.Button();
            this.tFile = new System.Windows.Forms.TextBox();
            this.chListClasses = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(469, 255);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 50;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bUpdate);
            this.groupBox1.Controls.Add(this.laDescription);
            this.groupBox1.Controls.Add(this.tDescription);
            this.groupBox1.Controls.Add(this.laDisplayName);
            this.groupBox1.Controls.Add(this.tDisplayName);
            this.groupBox1.Controls.Add(this.laInternalName);
            this.groupBox1.Controls.Add(this.tInternalName);
            this.groupBox1.Location = new System.Drawing.Point(229, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 143);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Metadata";
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(225, 108);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 41;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // laDescription
            // 
            this.laDescription.AutoSize = true;
            this.laDescription.Location = new System.Drawing.Point(6, 85);
            this.laDescription.Name = "laDescription";
            this.laDescription.Size = new System.Drawing.Size(60, 13);
            this.laDescription.TabIndex = 34;
            this.laDescription.Text = "Description";
            // 
            // tDescription
            // 
            this.tDescription.Location = new System.Drawing.Point(88, 82);
            this.tDescription.Name = "tDescription";
            this.tDescription.Size = new System.Drawing.Size(212, 20);
            this.tDescription.TabIndex = 33;
            // 
            // laDisplayName
            // 
            this.laDisplayName.AutoSize = true;
            this.laDisplayName.Location = new System.Drawing.Point(6, 59);
            this.laDisplayName.Name = "laDisplayName";
            this.laDisplayName.Size = new System.Drawing.Size(75, 13);
            this.laDisplayName.TabIndex = 32;
            this.laDisplayName.Text = "Display Name:";
            // 
            // tDisplayName
            // 
            this.tDisplayName.Location = new System.Drawing.Point(88, 56);
            this.tDisplayName.Name = "tDisplayName";
            this.tDisplayName.Size = new System.Drawing.Size(212, 20);
            this.tDisplayName.TabIndex = 31;
            // 
            // laInternalName
            // 
            this.laInternalName.AutoSize = true;
            this.laInternalName.Location = new System.Drawing.Point(6, 33);
            this.laInternalName.Name = "laInternalName";
            this.laInternalName.Size = new System.Drawing.Size(76, 13);
            this.laInternalName.TabIndex = 30;
            this.laInternalName.Text = "Internal Name:";
            // 
            // tInternalName
            // 
            this.tInternalName.Location = new System.Drawing.Point(88, 30);
            this.tInternalName.Name = "tInternalName";
            this.tInternalName.Size = new System.Drawing.Size(212, 20);
            this.tInternalName.TabIndex = 29;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(388, 255);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 48;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // laFile
            // 
            this.laFile.AutoSize = true;
            this.laFile.Location = new System.Drawing.Point(12, 9);
            this.laFile.Name = "laFile";
            this.laFile.Size = new System.Drawing.Size(39, 13);
            this.laFile.TabIndex = 46;
            this.laFile.Text = "ini File:";
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(469, 4);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(75, 23);
            this.bImport.TabIndex = 44;
            this.bImport.Text = "Import";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(388, 4);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 43;
            this.bBrowse.Text = "Browse";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // tFile
            // 
            this.tFile.Location = new System.Drawing.Point(80, 4);
            this.tFile.Name = "tFile";
            this.tFile.Size = new System.Drawing.Size(290, 20);
            this.tFile.TabIndex = 42;
            // 
            // chListClasses
            // 
            this.chListClasses.FormattingEnabled = true;
            this.chListClasses.Location = new System.Drawing.Point(15, 65);
            this.chListClasses.Name = "chListClasses";
            this.chListClasses.Size = new System.Drawing.Size(178, 184);
            this.chListClasses.TabIndex = 41;
            // 
            // ImportClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 337);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.laFile);
            this.Controls.Add(this.bImport);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.tFile);
            this.Controls.Add(this.chListClasses);
            this.Name = "ImportClasses";
            this.Text = "ImportClasses";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Label laDescription;
        private System.Windows.Forms.TextBox tDescription;
        private System.Windows.Forms.Label laDisplayName;
        private System.Windows.Forms.TextBox tDisplayName;
        private System.Windows.Forms.Label laInternalName;
        private System.Windows.Forms.TextBox tInternalName;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label laFile;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.TextBox tFile;
        private System.Windows.Forms.CheckedListBox chListClasses;
    }
}