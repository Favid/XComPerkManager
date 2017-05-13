namespace XcomPerkManager.Forms
{
    partial class ImportAbilities
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
            this.bClose = new System.Windows.Forms.Button();
            this.laFile = new System.Windows.Forms.Label();
            this.bImport = new System.Windows.Forms.Button();
            this.bBrowse = new System.Windows.Forms.Button();
            this.tFile = new System.Windows.Forms.TextBox();
            this.chListClasses = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(216, 351);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 38;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // laFile
            // 
            this.laFile.AutoSize = true;
            this.laFile.Location = new System.Drawing.Point(44, 19);
            this.laFile.Name = "laFile";
            this.laFile.Size = new System.Drawing.Size(47, 13);
            this.laFile.TabIndex = 37;
            this.laFile.Text = "INT File:";
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(299, 351);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(75, 23);
            this.bImport.TabIndex = 36;
            this.bImport.Text = "Import";
            this.bImport.UseVisualStyleBackColor = true;
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(261, 14);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 35;
            this.bBrowse.Text = "Browse";
            this.bBrowse.UseVisualStyleBackColor = true;
            // 
            // tFile
            // 
            this.tFile.Location = new System.Drawing.Point(97, 16);
            this.tFile.Name = "tFile";
            this.tFile.Size = new System.Drawing.Size(158, 20);
            this.tFile.TabIndex = 34;
            // 
            // chListClasses
            // 
            this.chListClasses.FormattingEnabled = true;
            this.chListClasses.Location = new System.Drawing.Point(47, 48);
            this.chListClasses.Name = "chListClasses";
            this.chListClasses.Size = new System.Drawing.Size(178, 259);
            this.chListClasses.TabIndex = 33;
            // 
            // ImportAbilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 386);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.laFile);
            this.Controls.Add(this.bImport);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.tFile);
            this.Controls.Add(this.chListClasses);
            this.Name = "ImportAbilities";
            this.Text = "ImportAbilities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label laFile;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.TextBox tFile;
        private System.Windows.Forms.CheckedListBox chListClasses;
    }
}