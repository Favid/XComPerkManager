using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XcomPerkManager
{
    public partial class EquipmentManager : Form
    {
        private string formerInternalName;

        public EquipmentManager()
        {
            InitializeComponent();
        }

        private void EquipmentManager_Load(object sender, EventArgs e)
        {
            ClassOverview owner = Owner as ClassOverview;
            tSquaddieLoadout.Text = owner.currentSoldier.equipment.squaddieLoadout;
            tPrimaryWeapon.Text = owner.currentSoldier.equipment.primaryWeapon;
            tSecondaryWeapon.Text = owner.currentSoldier.equipment.secondaryWeapon;
            tAllowedArmors.Text = owner.currentSoldier.equipment.allowedArmors;

            formerInternalName = owner.currentSoldier.metadata.internalName;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ClassOverview owner = Owner as ClassOverview;
            SavedSoldiersWriter writer = new SavedSoldiersWriter(owner.abilities);

            SoldierClassEquipment equipment = new SoldierClassEquipment();
            equipment.squaddieLoadout = tSquaddieLoadout.Text;
            equipment.primaryWeapon = tPrimaryWeapon.Text;
            equipment.secondaryWeapon = tSecondaryWeapon.Text;
            equipment.allowedArmors = tAllowedArmors.Text;

            writer.updateClassEquipment(formerInternalName, equipment);

            owner.updateSoldiers();
            owner.selectSoldier(formerInternalName);

            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
