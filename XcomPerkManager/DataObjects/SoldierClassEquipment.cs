using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XcomPerkManager.DataObjects;

namespace XcomPerkManager
{
    public class SoldierClassEquipment : ISoldierClassElement
    {
        public string squaddieLoadout { get; set; }
        public string primaryWeapon { get; set; }
        public string secondaryWeapon { get; set; }
        public string allowedArmors { get; set; }
        public List<Weapon> weapons { get; set; }

        public SoldierClassEquipment() : base()
        {
            squaddieLoadout = "";
            primaryWeapon = "";
            secondaryWeapon = "";
            allowedArmors = "soldier";

            weapons = new List<Weapon>();
        }

        public SoldierClassEquipment(SoldierClassEquipment other) : base()
        {
            squaddieLoadout = other.squaddieLoadout;
            primaryWeapon = other.primaryWeapon;
            secondaryWeapon = other.secondaryWeapon;
            allowedArmors = other.allowedArmors;

            weapons = new List<Weapon>();
            foreach(Weapon weapon in other.weapons)
            {
                weapons.Add(new Weapon(weapon));
            }
        }

        public XElement getXmlElement()
        {
            XElement equipmentElement = new XElement(Constants.XML_EQUIPMENT);

            equipmentElement.Add(new XElement(Constants.XML_EQUIPMENT_SQUADDIE_LOADOUT));
            equipmentElement.Element(Constants.XML_EQUIPMENT_SQUADDIE_LOADOUT).Value = this.squaddieLoadout;

            equipmentElement.Add(new XElement(Constants.XML_EQUIPMENT_PRIMARY_WEAPON));
            equipmentElement.Element(Constants.XML_EQUIPMENT_PRIMARY_WEAPON).Value = this.primaryWeapon;

            equipmentElement.Add(new XElement(Constants.XML_EQUIPMENT_SECONDARY_WEAPON));
            equipmentElement.Element(Constants.XML_EQUIPMENT_SECONDARY_WEAPON).Value = this.secondaryWeapon;

            equipmentElement.Add(new XElement(Constants.XML_EQUIPMENT_ALLOWED_ARMORS));
            equipmentElement.Element(Constants.XML_EQUIPMENT_ALLOWED_ARMORS).Value = this.allowedArmors;

            return equipmentElement;
        }

        public List<string> getRelevantClassTags()
        {
            List<string> tags = new List<string>();
            tags.Add(Constants.XML_EQUIPMENT_SQUADDIE_LOADOUT);
            tags.Add(Constants.XML_EQUIPMENT_PRIMARY_WEAPON);
            tags.Add(Constants.XML_EQUIPMENT_SECONDARY_WEAPON);
            tags.Add(Constants.XML_EQUIPMENT_ALLOWED_ARMORS);

            return tags;
        }

        public ValidationResult allowUpdate()
        {
            ValidationResult allowUpdate;
            allowUpdate.valid = true;
            allowUpdate.message = "";
            
            return allowUpdate;
        }

        public override bool Equals(object obj)
        {
            SoldierClassEquipment other = obj as SoldierClassEquipment;
            if (other == null)
            {
                return false;
            }

            if (!String.Equals(squaddieLoadout, other.squaddieLoadout))
            {
                return false;
            }

            if (!String.Equals(allowedArmors, other.allowedArmors))
            {
                return false;
            }

            if(!weapons.SequenceEqual(other.weapons))
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
