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
    }
}
