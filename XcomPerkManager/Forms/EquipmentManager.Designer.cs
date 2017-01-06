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
            this.lWeapons = new System.Windows.Forms.ListBox();
            this.weaponBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weaponBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bEdit = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.tWeaponSlot = new System.Windows.Forms.TextBox();
            this.lWeaponSlot = new System.Windows.Forms.Label();
            this.lWeaponName = new System.Windows.Forms.Label();
            this.tWeaponName = new System.Windows.Forms.TextBox();
            this.bSaveWeapon = new System.Windows.Forms.Button();
            this.bCancelWeapon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(499, 371);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 86;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(418, 371);
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
            this.laSecondaryWeapon.Location = new System.Drawing.Point(8, 91);
            this.laSecondaryWeapon.Name = "laSecondaryWeapon";
            this.laSecondaryWeapon.Size = new System.Drawing.Size(102, 13);
            this.laSecondaryWeapon.TabIndex = 84;
            this.laSecondaryWeapon.Text = "Secondary Weapon";
            // 
            // tSecondaryWeapon
            // 
            this.tSecondaryWeapon.Location = new System.Drawing.Point(116, 88);
            this.tSecondaryWeapon.Name = "tSecondaryWeapon";
            this.tSecondaryWeapon.Size = new System.Drawing.Size(244, 20);
            this.tSecondaryWeapon.TabIndex = 83;
            // 
            // laPrimaryWeapon
            // 
            this.laPrimaryWeapon.AutoSize = true;
            this.laPrimaryWeapon.Location = new System.Drawing.Point(10, 65);
            this.laPrimaryWeapon.Name = "laPrimaryWeapon";
            this.laPrimaryWeapon.Size = new System.Drawing.Size(85, 13);
            this.laPrimaryWeapon.TabIndex = 80;
            this.laPrimaryWeapon.Text = "Primary Weapon";
            // 
            // tPrimaryWeapon
            // 
            this.tPrimaryWeapon.Location = new System.Drawing.Point(116, 62);
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
            this.laAllowedArmors.Location = new System.Drawing.Point(12, 36);
            this.laAllowedArmors.Name = "laAllowedArmors";
            this.laAllowedArmors.Size = new System.Drawing.Size(79, 13);
            this.laAllowedArmors.TabIndex = 88;
            this.laAllowedArmors.Text = "Allowed Armors";
            // 
            // tAllowedArmors
            // 
            this.tAllowedArmors.Location = new System.Drawing.Point(118, 33);
            this.tAllowedArmors.Name = "tAllowedArmors";
            this.tAllowedArmors.Size = new System.Drawing.Size(244, 20);
            this.tAllowedArmors.TabIndex = 87;
            // 
            // lWeapons
            // 
            this.lWeapons.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.weaponBindingSource, "weaponName", true));
            this.lWeapons.DataSource = this.weaponBindingSource1;
            this.lWeapons.DisplayMember = "weaponName";
            this.lWeapons.FormattingEnabled = true;
            this.lWeapons.Location = new System.Drawing.Point(15, 197);
            this.lWeapons.Name = "lWeapons";
            this.lWeapons.Size = new System.Drawing.Size(267, 186);
            this.lWeapons.TabIndex = 89;
            this.lWeapons.ValueMember = "weaponName";
            // 
            // weaponBindingSource
            // 
            this.weaponBindingSource.DataSource = typeof(XcomPerkManager.DataObjects.Weapon);
            // 
            // weaponBindingSource1
            // 
            this.weaponBindingSource1.DataSource = typeof(XcomPerkManager.DataObjects.Weapon);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(288, 197);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 90;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(16, 168);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 91;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(97, 168);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 92;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // tWeaponSlot
            // 
            this.tWeaponSlot.Location = new System.Drawing.Point(374, 229);
            this.tWeaponSlot.Name = "tWeaponSlot";
            this.tWeaponSlot.Size = new System.Drawing.Size(140, 20);
            this.tWeaponSlot.TabIndex = 93;
            // 
            // lWeaponSlot
            // 
            this.lWeaponSlot.AutoSize = true;
            this.lWeaponSlot.Location = new System.Drawing.Point(289, 232);
            this.lWeaponSlot.Name = "lWeaponSlot";
            this.lWeaponSlot.Size = new System.Drawing.Size(69, 13);
            this.lWeaponSlot.TabIndex = 94;
            this.lWeaponSlot.Text = "Weapon Slot";
            // 
            // lWeaponName
            // 
            this.lWeaponName.AutoSize = true;
            this.lWeaponName.Location = new System.Drawing.Point(289, 258);
            this.lWeaponName.Name = "lWeaponName";
            this.lWeaponName.Size = new System.Drawing.Size(79, 13);
            this.lWeaponName.TabIndex = 96;
            this.lWeaponName.Text = "Weapon Name";
            // 
            // tWeaponName
            // 
            this.tWeaponName.Location = new System.Drawing.Point(374, 255);
            this.tWeaponName.Name = "tWeaponName";
            this.tWeaponName.Size = new System.Drawing.Size(140, 20);
            this.tWeaponName.TabIndex = 95;
            // 
            // bSaveWeapon
            // 
            this.bSaveWeapon.Location = new System.Drawing.Point(439, 281);
            this.bSaveWeapon.Name = "bSaveWeapon";
            this.bSaveWeapon.Size = new System.Drawing.Size(75, 23);
            this.bSaveWeapon.TabIndex = 98;
            this.bSaveWeapon.Text = "Save";
            this.bSaveWeapon.UseVisualStyleBackColor = true;
            this.bSaveWeapon.Click += new System.EventHandler(this.bSaveWeapon_Click);
            // 
            // bCancelWeapon
            // 
            this.bCancelWeapon.Location = new System.Drawing.Point(358, 281);
            this.bCancelWeapon.Name = "bCancelWeapon";
            this.bCancelWeapon.Size = new System.Drawing.Size(75, 23);
            this.bCancelWeapon.TabIndex = 97;
            this.bCancelWeapon.Text = "Cancel";
            this.bCancelWeapon.UseVisualStyleBackColor = true;
            this.bCancelWeapon.Click += new System.EventHandler(this.bCancelWeapon_Click);
            // 
            // EquipmentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 406);
            this.Controls.Add(this.bSaveWeapon);
            this.Controls.Add(this.bCancelWeapon);
            this.Controls.Add(this.lWeaponName);
            this.Controls.Add(this.tWeaponName);
            this.Controls.Add(this.lWeaponSlot);
            this.Controls.Add(this.tWeaponSlot);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.lWeapons);
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
        private System.Windows.Forms.ListBox lWeapons;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.BindingSource weaponBindingSource;
        private System.Windows.Forms.BindingSource weaponBindingSource1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.TextBox tWeaponSlot;
        private System.Windows.Forms.Label lWeaponSlot;
        private System.Windows.Forms.Label lWeaponName;
        private System.Windows.Forms.TextBox tWeaponName;
        private System.Windows.Forms.Button bSaveWeapon;
        private System.Windows.Forms.Button bCancelWeapon;
    }
}