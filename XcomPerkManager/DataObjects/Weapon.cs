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

        public string toString()
        {
            return weaponName + " " + weaponSlot;
        }


    }
}
