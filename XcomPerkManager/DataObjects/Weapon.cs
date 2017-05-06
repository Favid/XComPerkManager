using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XcomPerkManager.DataObjects
{
    public class Weapon
    {
        public string weaponName { get; set; }
        public string weaponSlot { get; set; }

        public Weapon()
        {
            weaponName = "";
            weaponSlot = "";
        }

        public Weapon(Weapon original)
        {
            weaponName = original.weaponName;
            weaponSlot = original.weaponSlot;
        }

        public string toString()
        {
            return weaponName + " " + weaponSlot;
        }

        public override bool Equals(object obj)
        {
            Weapon other = obj as Weapon;
            if(other == null)
            {
                return false;
            }
            
            if (!String.Equals(weaponName, other.weaponName))
            {
                return false;
            }

            if (!String.Equals(weaponSlot, other.weaponSlot))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
