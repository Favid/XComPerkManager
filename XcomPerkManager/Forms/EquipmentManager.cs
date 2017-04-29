using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using XcomPerkManager.DataObjects;

namespace XcomPerkManager
{
    public partial class EquipmentManager : Form
    {
        private string formerInternalName;
        private List<Weapon> soldiersWeapons;
        private BindingList<Weapon> weapons;

        public EquipmentManager()
        {
            InitializeComponent();
        }

        private void EquipmentManager_Load(object sender, EventArgs e)
        {
            ClassOverview owner = Owner as ClassOverview;
            tSquaddieLoadout.Text = owner.currentSoldier.equipment.squaddieLoadout;
            //tPrimaryWeapon.Text = owner.currentSoldier.equipment.primaryWeapon;
            //tSecondaryWeapon.Text = owner.currentSoldier.equipment.secondaryWeapon;
            tAllowedArmors.Text = owner.currentSoldier.equipment.allowedArmors;

            formerInternalName = owner.currentSoldier.metadata.internalName;

            soldiersWeapons = new List<Weapon>(); // TODO will be owner.currentSoldier.equipment.weapons

            weapons = new BindingList<Weapon>(soldiersWeapons);
            lWeapons.DataSource = weapons;

            setControlsInitialState();
        }

        private void setControlsInitialState()
        {
            lWeaponSlot.Visible = false;
            lWeaponName.Visible = false;

            tWeaponSlot.Visible = false;
            tWeaponName.Visible = false;

            bSaveWeapon.Visible = false;
            bCancelWeapon.Visible = false;

            lWeapons.Enabled = true;

            bAdd.Enabled = true;
            bDelete.Enabled = true;
            bEdit.Enabled = true;

            bSave.Enabled = true;
        }

        private void setControlsEditingWeapon()
        {
            lWeaponSlot.Visible = true;
            lWeaponName.Visible = true;

            tWeaponSlot.Visible = true;
            tWeaponName.Visible = true;

            bSaveWeapon.Visible = true;
            bCancelWeapon.Visible = true;

            lWeapons.Enabled = false;

            bAdd.Enabled = false;
            bDelete.Enabled = false;
            bEdit.Enabled = false;

            bSave.Enabled = false;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ClassOverview owner = Owner as ClassOverview;

            SoldierClassEquipment equipment = new SoldierClassEquipment();
            equipment.squaddieLoadout = tSquaddieLoadout.Text;
            //equipment.primaryWeapon = tPrimaryWeapon.Text;
            //equipment.secondaryWeapon = tSecondaryWeapon.Text;
            equipment.allowedArmors = tAllowedArmors.Text;

            ValidationResult allowUpdate = equipment.allowUpdate();
            if (!allowUpdate.valid)
            {
                MessageBox.Show(allowUpdate.message, "Cannot save", MessageBoxButtons.OK);
                return;
            }

            SavedSoldiersManager manager = new SavedSoldiersManager();
            manager.updateClassElement(formerInternalName, equipment, Constants.XML_EQUIPMENT);

            owner.updateSoldiers();
            owner.selectSoldier(formerInternalName);

            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            Weapon weaponToEdit = lWeapons.SelectedItem as Weapon;

            if (weaponToEdit != null)
            {
                setControlsEditingWeapon();

                tWeaponSlot.Text = weaponToEdit.weaponSlot;
                tWeaponName.Text = weaponToEdit.weaponName;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            
            Weapon weapon = new Weapon();
            weapon.weaponName = "new";
            weapon.weaponSlot = "primary";
            weapons.Add(weapon);

            lWeapons.DataSource = weapons;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            Weapon weaponToRemove = lWeapons.SelectedItem as Weapon;

            if(weaponToRemove != null)
            {
                weapons.Remove(weaponToRemove);
                lWeapons.DataSource = weapons;
            }
        }

        private void bCancelWeapon_Click(object sender, EventArgs e)
        {
            tWeaponSlot.Text = "";
            tWeaponName.Text = "";

            setControlsInitialState();
        }

        private void bSaveWeapon_Click(object sender, EventArgs e)
        {
            Weapon weaponToEdit = lWeapons.SelectedItem as Weapon;
            weaponToEdit.weaponSlot = tWeaponSlot.Text;
            weaponToEdit.weaponName = tWeaponName.Text;
            weapons[lWeapons.SelectedIndex] = weaponToEdit;
            
            lWeapons.DataSource = weapons;

            setControlsInitialState();
        }
    }
}
