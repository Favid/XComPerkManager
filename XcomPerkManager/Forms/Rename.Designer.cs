namespace XcomPerkManager.Forms
{
    partial class Rename
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
            this.laCurrentNameLabel = new System.Windows.Forms.Label();
            this.laCurrentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tNewName = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laCurrentNameLabel
            // 
            this.laCurrentNameLabel.AutoSize = true;
            this.laCurrentNameLabel.Location = new System.Drawing.Point(13, 13);
            this.laCurrentNameLabel.Name = "laCurrentNameLabel";
            this.laCurrentNameLabel.Size = new System.Drawing.Size(73, 13);
            this.laCurrentNameLabel.TabIndex = 0;
            this.laCurrentNameLabel.Text = "Current name:";
            // 
            // laCurrentName
            // 
            this.laCurrentName.AutoSize = true;
            this.laCurrentName.Location = new System.Drawing.Point(92, 13);
            this.laCurrentName.Name = "laCurrentName";
            this.laCurrentName.Size = new System.Drawing.Size(13, 13);
            this.laCurrentName.TabIndex = 1;
            this.laCurrentName.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New name:";
            // 
            // tNewName
            // 
            this.tNewName.Location = new System.Drawing.Point(95, 40);
            this.tNewName.Name = "tNewName";
            this.tNewName.Size = new System.Drawing.Size(164, 20);
            this.tNewName.TabIndex = 3;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(95, 66);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(184, 66);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 5;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // Rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tNewName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laCurrentName);
            this.Controls.Add(this.laCurrentNameLabel);
            this.Name = "Rename";
            this.Text = "Rename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laCurrentNameLabel;
        private System.Windows.Forms.Label laCurrentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNewName;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
    }
}