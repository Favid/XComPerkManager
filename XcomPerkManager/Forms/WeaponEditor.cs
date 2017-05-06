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

namespace XcomPerkManager.Forms
{
    public partial class WeaponEditor : Form
    {
        public Weapon oldWeapon { get; private set; }
        public Weapon newWeapon { get; private set; }

        public EditorState editorState { get; private set; }

        public WeaponEditor(Weapon weapon, EditorState editorState)
        {
            InitializeComponent();

            if(weapon == null)
            {
                oldWeapon = new Weapon();
                newWeapon = new Weapon();
            }
            else
            {
                oldWeapon = new Weapon(weapon);
                newWeapon = new Weapon(weapon);
            }
            
            tWeaponName.Text = oldWeapon.weaponName;
            tWeaponSlot.Text = oldWeapon.weaponSlot;

            this.editorState = editorState;
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            // TODO validate

            newWeapon.weaponName = tWeaponName.Text;
            newWeapon.weaponSlot = tWeaponSlot.Text;

            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            newWeapon = oldWeapon;
            editorState = EditorState.CANCEL;

            Close();
        }
    }
}
