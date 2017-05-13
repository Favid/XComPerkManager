namespace XcomPerkManager.Forms
{
    partial class ExportManager
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
            this.chListClasses = new System.Windows.Forms.CheckedListBox();
            this.tFolder = new System.Windows.Forms.TextBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.bExport = new System.Windows.Forms.Button();
            this.laFolder = new System.Windows.Forms.Label();
            this.gCompatibility = new System.Windows.Forms.GroupBox();
            this.opLongWar2 = new System.Windows.Forms.RadioButton();
            this.opVanilla = new System.Windows.Forms.RadioButton();
            this.bClose = new System.Windows.Forms.Button();
            this.gCompatibility.SuspendLayout();
            this.SuspendLayout();
            // 
            // chListClasses
            // 
            this.chListClasses.FormattingEnabled = true;
            this.chListClasses.Location = new System.Drawing.Point(27, 30);
            this.chListClasses.Name = "chListClasses";
            this.chListClasses.Size = new System.Drawing.Size(178, 259);
            this.chListClasses.TabIndex = 0;
            // 
            // tFolder
            // 
            this.tFolder.Location = new System.Drawing.Point(266, 30);
            this.tFolder.Name = "tFolder";
            this.tFolder.Size = new System.Drawing.Size(158, 20);
            this.tFolder.TabIndex = 1;
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(430, 28);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 2;
            this.bBrowse.Text = "Browse";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(349, 266);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(75, 23);
            this.bExport.TabIndex = 7;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = true;
            // 
            // laFolder
            // 
            this.laFolder.AutoSize = true;
            this.laFolder.Location = new System.Drawing.Point(221, 33);
            this.laFolder.Name = "laFolder";
            this.laFolder.Size = new System.Drawing.Size(39, 13);
            this.laFolder.TabIndex = 28;
            this.laFolder.Text = "Folder:";
            // 
            // gCompatibility
            // 
            this.gCompatibility.Controls.Add(this.opLongWar2);
            this.gCompatibility.Controls.Add(this.opVanilla);
            this.gCompatibility.Location = new System.Drawing.Point(27, 318);
            this.gCompatibility.Name = "gCompatibility";
            this.gCompatibility.Size = new System.Drawing.Size(200, 78);
            this.gCompatibility.TabIndex = 31;
            this.gCompatibility.TabStop = false;
            this.gCompatibility.Text = "Compatibility";
            // 
            // opLongWar2
            // 
            this.opLongWar2.AutoSize = true;
            this.opLongWar2.Location = new System.Drawing.Point(6, 42);
            this.opLongWar2.Name = "opLongWar2";
            this.opLongWar2.Size = new System.Drawing.Size(81, 17);
            this.opLongWar2.TabIndex = 32;
            this.opLongWar2.TabStop = true;
            this.opLongWar2.Text = "Long War 2";
            this.opLongWar2.UseVisualStyleBackColor = true;
            // 
            // opVanilla
            // 
            this.opVanilla.AutoSize = true;
            this.opVanilla.Location = new System.Drawing.Point(6, 19);
            this.opVanilla.Name = "opVanilla";
            this.opVanilla.Size = new System.Drawing.Size(56, 17);
            this.opVanilla.TabIndex = 31;
            this.opVanilla.TabStop = true;
            this.opVanilla.Text = "Vanilla";
            this.opVanilla.UseVisualStyleBackColor = true;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(266, 266);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 32;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // ExportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 419);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.gCompatibility);
            this.Controls.Add(this.laFolder);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.tFolder);
            this.Controls.Add(this.chListClasses);
            this.Name = "ExportManager";
            this.Text = "ExportManager";
            this.gCompatibility.ResumeLayout(false);
            this.gCompatibility.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chListClasses;
        private System.Windows.Forms.TextBox tFolder;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Label laFolder;
        private System.Windows.Forms.GroupBox gCompatibility;
        private System.Windows.Forms.RadioButton opLongWar2;
        private System.Windows.Forms.RadioButton opVanilla;
        private System.Windows.Forms.Button bClose;
    }
}