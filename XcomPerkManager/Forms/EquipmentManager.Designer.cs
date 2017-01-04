namespace XcomPerkManager
{
    partial class EquipmentManager
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
            this.components = new System.ComponentModel.Container();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.laSecondaryWeapon = new System.Windows.Forms.Label();
            this.tSecondaryWeapon = new System.Windows.Forms.TextBox();
            this.laPrimaryWeapon = new System.Windows.Forms.Label();
            this.tPrimaryWeapon = new System.Windows.Forms.TextBox();
            this.laSquaddieLoadout = new System.Windows.Forms.Label();
            this.tSquaddieLoadout = new System.Windows.Forms.TextBox();
            this.laAllowedArmors = new System.Windows.Forms.Label();
            this.tAllowedArmors = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.weaponBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.weaponBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(288, 109);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 86;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(207, 109);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 85;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // laSecondaryWeapon
            // 
            this.laSecondaryWeapon.AutoSize = true;
            this.laSecondaryWeapon.Location = new System.Drawing.Point(10, 60);
            this.laSecondaryWeapon.Name = "laSecondaryWeapon";
            this.laSecondaryWeapon.Size = new System.Drawing.Size(102, 13);
            this.laSecondaryWeapon.TabIndex = 84;
            this.laSecondaryWeapon.Text = "Secondary Weapon";
            // 
            // tSecondaryWeapon
            // 
            this.tSecondaryWeapon.Location = new System.Drawing.Point(118, 57);
            this.tSecondaryWeapon.Name = "tSecondaryWeapon";
            this.tSecondaryWeapon.Size = new System.Drawing.Size(244, 20);
            this.tSecondaryWeapon.TabIndex = 83;
            // 
            // laPrimaryWeapon
            // 
            this.laPrimaryWeapon.AutoSize = true;
            this.laPrimaryWeapon.Location = new System.Drawing.Point(12, 34);
            this.laPrimaryWeapon.Name = "laPrimaryWeapon";
            this.laPrimaryWeapon.Size = new System.Drawing.Size(85, 13);
            this.laPrimaryWeapon.TabIndex = 80;
            this.laPrimaryWeapon.Text = "Primary Weapon";
            // 
            // tPrimaryWeapon
            // 
            this.tPrimaryWeapon.Location = new System.Drawing.Point(118, 31);
            this.tPrimaryWeapon.Name = "tPrimaryWeapon";
            this.tPrimaryWeapon.Size = new System.Drawing.Size(244, 20);
            this.tPrimaryWeapon.TabIndex = 79;
            // 
            // laSquaddieLoadout
            // 
            this.laSquaddieLoadout.AutoSize = true;
            this.laSquaddieLoadout.Location = new System.Drawing.Point(10, 9);
            this.laSquaddieLoadout.Name = "laSquaddieLoadout";
            this.laSquaddieLoadout.Size = new System.Drawing.Size(94, 13);
            this.laSquaddieLoadout.TabIndex = 78;
            this.laSquaddieLoadout.Text = "Squaddie Loadout";
            // 
            // tSquaddieLoadout
            // 
            this.tSquaddieLoadout.Location = new System.Drawing.Point(118, 6);
            this.tSquaddieLoadout.Name = "tSquaddieLoadout";
            this.tSquaddieLoadout.Size = new System.Drawing.Size(244, 20);
            this.tSquaddieLoadout.TabIndex = 77;
            // 
            // laAllowedArmors
            // 
            this.laAllowedArmors.AutoSize = true;
            this.laAllowedArmors.Location = new System.Drawing.Point(12, 86);
            this.laAllowedArmors.Name = "laAllowedArmors";
            this.laAllowedArmors.Size = new System.Drawing.Size(79, 13);
            this.laAllowedArmors.TabIndex = 88;
            this.laAllowedArmors.Text = "Allowed Armors";
            // 
            // tAllowedArmors
            // 
            this.tAllowedArmors.Location = new System.Drawing.Point(118, 83);
            this.tAllowedArmors.Name = "tAllowedArmors";
            this.tAllowedArmors.Size = new System.Drawing.Size(244, 20);
            this.tAllowedArmors.TabIndex = 87;
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.weaponBindingSource, "weaponName", true));
            this.listBox1.DataSource = this.weaponBindingSource1;
            this.listBox1.DisplayMember = "weaponName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 197);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 186);
            this.listBox1.TabIndex = 89;
            this.listBox1.ValueMember = "weaponName";
            // 
            // weaponBindingSource
            // 
            this.weaponBindingSource.DataSource = typeof(XcomPerkManager.DataObjects.Weapon);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weaponBindingSource1
            // 
            this.weaponBindingSource1.DataSource = typeof(XcomPerkManager.DataObjects.Weapon);
            // 
            // EquipmentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.laAllowedArmors);
            this.Controls.Add(this.tAllowedArmors);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.laSecondaryWeapon);
            this.Controls.Add(this.tSecondaryWeapon);
            this.Controls.Add(this.laPrimaryWeapon);
            this.Controls.Add(this.tPrimaryWeapon);
            this.Controls.Add(this.laSquaddieLoadout);
            this.Controls.Add(this.tSquaddieLoadout);
            this.Name = "EquipmentManager";
            this.Text = "EquipmentManager";
            this.Load += new System.EventHandler(this.EquipmentManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label laSecondaryWeapon;
        private System.Windows.Forms.TextBox tSecondaryWeapon;
        private System.Windows.Forms.Label laPrimaryWeapon;
        private System.Windows.Forms.TextBox tPrimaryWeapon;
        private System.Windows.Forms.Label laSquaddieLoadout;
        private System.Windows.Forms.TextBox tSquaddieLoadout;
        private System.Windows.Forms.Label laAllowedArmors;
        private System.Windows.Forms.TextBox tAllowedArmors;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource weaponBindingSource;
        private System.Windows.Forms.BindingSource weaponBindingSource1;
    }
}