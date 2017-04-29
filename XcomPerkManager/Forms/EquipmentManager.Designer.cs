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
            this.gWeapons = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource1)).BeginInit();
            this.gWeapons.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(426, 371);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 86;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(345, 371);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 85;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
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
            this.tSquaddieLoadout.Size = new System.Drawing.Size(383, 20);
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
            this.tAllowedArmors.Size = new System.Drawing.Size(383, 20);
            this.tAllowedArmors.TabIndex = 87;
            // 
            // lWeapons
            // 
            this.lWeapons.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.weaponBindingSource, "weaponName", true));
            this.lWeapons.DataSource = this.weaponBindingSource1;
            this.lWeapons.DisplayMember = "weaponName";
            this.lWeapons.FormattingEnabled = true;
            this.lWeapons.Location = new System.Drawing.Point(6, 59);
            this.lWeapons.Name = "lWeapons";
            this.lWeapons.Size = new System.Drawing.Size(237, 186);
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
            this.bEdit.Location = new System.Drawing.Point(168, 30);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 90;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(6, 30);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 91;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(87, 30);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 92;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // tWeaponSlot
            // 
            this.tWeaponSlot.Location = new System.Drawing.Point(334, 65);
            this.tWeaponSlot.Name = "tWeaponSlot";
            this.tWeaponSlot.Size = new System.Drawing.Size(140, 20);
            this.tWeaponSlot.TabIndex = 93;
            // 
            // lWeaponSlot
            // 
            this.lWeaponSlot.AutoSize = true;
            this.lWeaponSlot.Location = new System.Drawing.Point(249, 68);
            this.lWeaponSlot.Name = "lWeaponSlot";
            this.lWeaponSlot.Size = new System.Drawing.Size(69, 13);
            this.lWeaponSlot.TabIndex = 94;
            this.lWeaponSlot.Text = "Weapon Slot";
            // 
            // lWeaponName
            // 
            this.lWeaponName.AutoSize = true;
            this.lWeaponName.Location = new System.Drawing.Point(249, 94);
            this.lWeaponName.Name = "lWeaponName";
            this.lWeaponName.Size = new System.Drawing.Size(79, 13);
            this.lWeaponName.TabIndex = 96;
            this.lWeaponName.Text = "Weapon Name";
            // 
            // tWeaponName
            // 
            this.tWeaponName.Location = new System.Drawing.Point(334, 91);
            this.tWeaponName.Name = "tWeaponName";
            this.tWeaponName.Size = new System.Drawing.Size(140, 20);
            this.tWeaponName.TabIndex = 95;
            // 
            // bSaveWeapon
            // 
            this.bSaveWeapon.Location = new System.Drawing.Point(400, 117);
            this.bSaveWeapon.Name = "bSaveWeapon";
            this.bSaveWeapon.Size = new System.Drawing.Size(75, 23);
            this.bSaveWeapon.TabIndex = 98;
            this.bSaveWeapon.Text = "Save";
            this.bSaveWeapon.UseVisualStyleBackColor = true;
            this.bSaveWeapon.Click += new System.EventHandler(this.bSaveWeapon_Click);
            // 
            // bCancelWeapon
            // 
            this.bCancelWeapon.Location = new System.Drawing.Point(319, 117);
            this.bCancelWeapon.Name = "bCancelWeapon";
            this.bCancelWeapon.Size = new System.Drawing.Size(75, 23);
            this.bCancelWeapon.TabIndex = 97;
            this.bCancelWeapon.Text = "Cancel";
            this.bCancelWeapon.UseVisualStyleBackColor = true;
            this.bCancelWeapon.Click += new System.EventHandler(this.bCancelWeapon_Click);
            // 
            // gWeapons
            // 
            this.gWeapons.Controls.Add(this.bAdd);
            this.gWeapons.Controls.Add(this.lWeapons);
            this.gWeapons.Controls.Add(this.bSaveWeapon);
            this.gWeapons.Controls.Add(this.bDelete);
            this.gWeapons.Controls.Add(this.bCancelWeapon);
            this.gWeapons.Controls.Add(this.bEdit);
            this.gWeapons.Controls.Add(this.lWeaponName);
            this.gWeapons.Controls.Add(this.tWeaponSlot);
            this.gWeapons.Controls.Add(this.tWeaponName);
            this.gWeapons.Controls.Add(this.lWeaponSlot);
            this.gWeapons.Location = new System.Drawing.Point(12, 62);
            this.gWeapons.Name = "gWeapons";
            this.gWeapons.Size = new System.Drawing.Size(489, 303);
            this.gWeapons.TabIndex = 99;
            this.gWeapons.TabStop = false;
            this.gWeapons.Text = "Weapons";
            // 
            // EquipmentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 406);
            this.Controls.Add(this.gWeapons);
            this.Controls.Add(this.laAllowedArmors);
            this.Controls.Add(this.tAllowedArmors);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.laSquaddieLoadout);
            this.Controls.Add(this.tSquaddieLoadout);
            this.Name = "EquipmentManager";
            this.Text = "EquipmentManager";
            this.Load += new System.EventHandler(this.EquipmentManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource1)).EndInit();
            this.gWeapons.ResumeLayout(false);
            this.gWeapons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
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
        private System.Windows.Forms.GroupBox gWeapons;
    }
}