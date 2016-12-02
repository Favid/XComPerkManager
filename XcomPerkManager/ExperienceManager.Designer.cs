namespace XcomPerkManager
{
    partial class ExperienceManager
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
            this.bCancel = new System.Windows.Forms.Button();
            this.laKillAssistsPerKill = new System.Windows.Forms.Label();
            this.tKillAssistsPerKill = new System.Windows.Forms.TextBox();
            this.laNumberInDeck = new System.Windows.Forms.Label();
            this.tNumberInDeck = new System.Windows.Forms.TextBox();
            this.laNumberInForcedDeck = new System.Windows.Forms.Label();
            this.tNumberInForcedDeck = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(98, 101);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 86;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(17, 101);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 85;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // laKillAssistsPerKill
            // 
            this.laKillAssistsPerKill.AutoSize = true;
            this.laKillAssistsPerKill.Location = new System.Drawing.Point(7, 66);
            this.laKillAssistsPerKill.Name = "laKillAssistsPerKill";
            this.laKillAssistsPerKill.Size = new System.Drawing.Size(90, 13);
            this.laKillAssistsPerKill.TabIndex = 84;
            this.laKillAssistsPerKill.Text = "Kill Assists Per Kill";
            // 
            // tKillAssistsPerKill
            // 
            this.tKillAssistsPerKill.Location = new System.Drawing.Point(134, 63);
            this.tKillAssistsPerKill.Name = "tKillAssistsPerKill";
            this.tKillAssistsPerKill.Size = new System.Drawing.Size(33, 20);
            this.tKillAssistsPerKill.TabIndex = 83;
            // 
            // laNumberInDeck
            // 
            this.laNumberInDeck.AutoSize = true;
            this.laNumberInDeck.Location = new System.Drawing.Point(7, 40);
            this.laNumberInDeck.Name = "laNumberInDeck";
            this.laNumberInDeck.Size = new System.Drawing.Size(85, 13);
            this.laNumberInDeck.TabIndex = 80;
            this.laNumberInDeck.Text = "Number In Deck";
            // 
            // tNumberInDeck
            // 
            this.tNumberInDeck.Location = new System.Drawing.Point(134, 37);
            this.tNumberInDeck.Name = "tNumberInDeck";
            this.tNumberInDeck.Size = new System.Drawing.Size(33, 20);
            this.tNumberInDeck.TabIndex = 79;
            // 
            // laNumberInForcedDeck
            // 
            this.laNumberInForcedDeck.AutoSize = true;
            this.laNumberInForcedDeck.Location = new System.Drawing.Point(7, 14);
            this.laNumberInForcedDeck.Name = "laNumberInForcedDeck";
            this.laNumberInForcedDeck.Size = new System.Drawing.Size(121, 13);
            this.laNumberInForcedDeck.TabIndex = 78;
            this.laNumberInForcedDeck.Text = "Number In Forced Deck";
            // 
            // tNumberInForcedDeck
            // 
            this.tNumberInForcedDeck.Location = new System.Drawing.Point(134, 11);
            this.tNumberInForcedDeck.Name = "tNumberInForcedDeck";
            this.tNumberInForcedDeck.Size = new System.Drawing.Size(33, 20);
            this.tNumberInForcedDeck.TabIndex = 77;
            // 
            // ExperienceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 152);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.laKillAssistsPerKill);
            this.Controls.Add(this.tKillAssistsPerKill);
            this.Controls.Add(this.laNumberInDeck);
            this.Controls.Add(this.tNumberInDeck);
            this.Controls.Add(this.laNumberInForcedDeck);
            this.Controls.Add(this.tNumberInForcedDeck);
            this.Name = "ExperienceManager";
            this.Text = "ExperienceManager";
            this.Load += new System.EventHandler(this.ExperienceManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label laKillAssistsPerKill;
        private System.Windows.Forms.TextBox tKillAssistsPerKill;
        private System.Windows.Forms.Label laNumberInDeck;
        private System.Windows.Forms.TextBox tNumberInDeck;
        private System.Windows.Forms.Label laNumberInForcedDeck;
        private System.Windows.Forms.TextBox tNumberInForcedDeck;
    }
}