﻿namespace XcomPerkManager.Forms
{
    partial class WeaponEditor
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
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tWeaponName = new System.Windows.Forms.TextBox();
            this.laWeapon = new System.Windows.Forms.Label();
            this.laWeaponType = new System.Windows.Forms.Label();
            this.tWeaponSlot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(190, 174);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 11;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(101, 174);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 10;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // tWeaponName
            // 
            this.tWeaponName.Location = new System.Drawing.Point(101, 19);
            this.tWeaponName.Name = "tWeaponName";
            this.tWeaponName.Size = new System.Drawing.Size(164, 20);
            this.tWeaponName.TabIndex = 9;
            // 
            // laWeapon
            // 
            this.laWeapon.AutoSize = true;
            this.laWeapon.Location = new System.Drawing.Point(17, 22);
            this.laWeapon.Name = "laWeapon";
            this.laWeapon.Size = new System.Drawing.Size(80, 13);
            this.laWeapon.TabIndex = 8;
            this.laWeapon.Text = "Weapon name:";
            // 
            // laWeaponType
            // 
            this.laWeaponType.AutoSize = true;
            this.laWeaponType.Location = new System.Drawing.Point(17, 48);
            this.laWeaponType.Name = "laWeaponType";
            this.laWeaponType.Size = new System.Drawing.Size(70, 13);
            this.laWeaponType.TabIndex = 6;
            this.laWeaponType.Text = "Weapon slot:";
            // 
            // tWeaponSlot
            // 
            this.tWeaponSlot.Location = new System.Drawing.Point(101, 45);
            this.tWeaponSlot.Name = "tWeaponSlot";
            this.tWeaponSlot.Size = new System.Drawing.Size(164, 20);
            this.tWeaponSlot.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Common weapon slots:\r\n - eInv_PrimaryWeapon\r\n - eInv_SecondaryWeapon\r\n";
            // 
            // WeaponEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tWeaponSlot);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tWeaponName);
            this.Controls.Add(this.laWeapon);
            this.Controls.Add(this.laWeaponType);
            this.Name = "WeaponEditor";
            this.Text = "WeaponEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox tWeaponName;
        private System.Windows.Forms.Label laWeapon;
        private System.Windows.Forms.Label laWeaponType;
        private System.Windows.Forms.TextBox tWeaponSlot;
        private System.Windows.Forms.Label label1;
    }
}