using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XcomPerkManager
{
    public class Ability
    {
        public string internalName { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public WeaponSlot weaponSlot { get; set; }
        public string requiredMod { get; set; }

        public Ability()
        {
            internalName = "";
            displayName = "";
            description = "";
            weaponSlot = WeaponSlot.None;
            requiredMod = "";
        }

        public Ability(Ability other)
        {
            internalName = other.internalName;
            displayName = other.displayName;
            description = other.description;
            weaponSlot = other.weaponSlot;
            requiredMod = other.requiredMod;
        }

        public override bool Equals(object obj)
        {
            Ability castedObj = obj as Ability;

            if(castedObj == null)
            {
                return base.Equals(obj);
            }

            return (internalName.Equals(castedObj.internalName));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
