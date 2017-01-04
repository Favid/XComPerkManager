using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XcomPerkManager.DataObjects;

namespace XcomPerkManager
{
    public partial class EquipmentManager : Form
    {
        private string formerInternalName;
        private List<Weapon> ws;
        private BindingList<Weapon> weapons;

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

            ws = new List<Weapon>();

            Weapon w = new Weapon();
            w.weaponName = "test";
            w.weaponSlot = "primary";
            ws.Add(w);

            Weapon w2 = new Weapon();
            w2.weaponName = "test2";
            w2.weaponSlot = "primary";
            ws.Add(w2);

            weapons = new BindingList<Weapon>();
            weapons.Add(w);
            weapons.Add(w2);

            //listBox1.DataSource = ws;
            listBox1.DataSource = weapons;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ClassOverview owner = Owner as ClassOverview;

            SoldierClassEquipment equipment = new SoldierClassEquipment();
            equipment.squaddieLoadout = tSquaddieLoadout.Text;
            equipment.primaryWeapon = tPrimaryWeapon.Text;
            equipment.secondaryWeapon = tSecondaryWeapon.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Weapon w2 = new Weapon();
            w2.weaponName = "test3";
            w2.weaponSlot = "primary";
            weapons.Add(w2);
            
            listBox1.DataSource = weapons;


        }
    }
}
