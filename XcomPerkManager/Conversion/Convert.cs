using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using XcomPerkManager.DataObjects;

namespace XcomPerkManager.Conversion
{
    public static class Convert
    {
        public static SoldierClassMetadata toDriverMetadata(XElement xmlMetadata)
        {
            SoldierClassMetadata metadata = new SoldierClassMetadata();
            metadata.internalName = xmlMetadata.Element(Constants.XML_METADATA_INTERNAL_NAME).Value;
            metadata.displayName = xmlMetadata.Element(Constants.XML_METADATA_DISPLAY_NAME).Value;
            metadata.description = xmlMetadata.Element(Constants.XML_METADATA_DESCRIPTION).Value;
            metadata.iconString = xmlMetadata.Element(Constants.XML_METADATA_ICON_STRING).Value;

            return metadata;
        }

        public static SoldierClassExperience toDriverExperience(XElement xmlExperience)
        {
            SoldierClassExperience experience = new SoldierClassExperience();
            experience.numberInForcedDeck = int.Parse(xmlExperience.Element(Constants.XML_EXPERIENCE_NUM_IN_FORCED_DECK).Value);
            experience.numberInDeck = int.Parse(xmlExperience.Element(Constants.XML_EXPERIENCE_NUM_IN_DECK).Value);
            experience.killAssistsPerKill = int.Parse(xmlExperience.Element(Constants.XML_EXPERIENCE_KILL_ASSISTS_PER_KILL).Value);

            return experience;
        }
                               
        public static SoldierClassEquipment toDriverEquipment(XElement xmlEquipment)
        {
            SoldierClassEquipment equipment = new SoldierClassEquipment();
            equipment.squaddieLoadout = xmlEquipment.Element(Constants.XML_EQUIPMENT_SQUADDIE_LOADOUT).Value;
            equipment.allowedArmors = xmlEquipment.Element(Constants.XML_EQUIPMENT_ALLOWED_ARMORS).Value;
            equipment.weapons = toDriverWeapons(xmlEquipment.Element(Constants.XML_EQUIPMENT_WEAPONS));

            return equipment;
        }

        public static List<Weapon> toDriverWeapons(XElement xmlWeapons)
        {
            List<Weapon> weapons = new List<Weapon>();

            foreach(XElement xmlWeapon in xmlWeapons.Elements())
            {
                weapons.Add(toDriverWeapon(xmlWeapon));
            }

            return weapons;
        }

        public static Weapon toDriverWeapon(XElement xmlWeapon)
        {
            Weapon weapon = new Weapon();
            weapon.weaponName = xmlWeapon.Element(Constants.XML_EQUIPMENT_WEAPON_NAME).Value;
            weapon.weaponSlot = xmlWeapon.Element(Constants.XML_EQUIPMENT_WEAPON_SLOT).Value;

            return weapon;
        }

        public static XElement toXmlMetadata(SoldierClassMetadata metadata)
        {
            XElement xmlMetadata = new XElement(Constants.XML_METADATA);
            addBaseChild(xmlMetadata, Constants.XML_METADATA_INTERNAL_NAME, metadata.internalName);
            addBaseChild(xmlMetadata, Constants.XML_METADATA_DISPLAY_NAME, metadata.displayName);
            addBaseChild(xmlMetadata, Constants.XML_METADATA_DESCRIPTION, metadata.description);
            addBaseChild(xmlMetadata, Constants.XML_METADATA_ICON_STRING, metadata.iconString);
            
            return xmlMetadata;
        }

        public static XElement toXmlExperience(SoldierClassExperience experience)
        {
            XElement xmlExperience = new XElement(Constants.XML_EXPERIENCE);
            addBaseChild(xmlExperience, Constants.XML_EXPERIENCE_NUM_IN_FORCED_DECK, experience.numberInForcedDeck.ToString());
            addBaseChild(xmlExperience, Constants.XML_EXPERIENCE_NUM_IN_DECK, experience.numberInDeck.ToString());
            addBaseChild(xmlExperience, Constants.XML_EXPERIENCE_KILL_ASSISTS_PER_KILL, experience.killAssistsPerKill.ToString());

            return xmlExperience;
        }

        public static XElement toXmlEquipment(SoldierClassEquipment equipment)
        {
            XElement xmlWeapon = new XElement(Constants.XML_EQUIPMENT);

            addBaseChild(xmlWeapon, Constants.XML_EQUIPMENT_SQUADDIE_LOADOUT, equipment.squaddieLoadout);
            addBaseChild(xmlWeapon, Constants.XML_EQUIPMENT_ALLOWED_ARMORS, equipment.allowedArmors);
            addXmlChild(xmlWeapon, toXmlWeapons(equipment.weapons));

            return xmlWeapon;
        }

        public static XElement toXmlWeapons(List<Weapon> weapons)
        {
            XElement xmlWeapons = new XElement(Constants.XML_EQUIPMENT_WEAPONS);

            foreach(Weapon weapon in weapons)
            {
                addXmlChild(xmlWeapons, toXmlWeapon(weapon));
            }

            return xmlWeapons;
        }

        public static XElement toXmlWeapon(Weapon weapon)
        {
            XElement xmlWeapon = new XElement(Constants.XML_EQUIPMENT_WEAPON);

            addBaseChild(xmlWeapon, Constants.XML_EQUIPMENT_WEAPON_NAME, weapon.weaponName);
            addBaseChild(xmlWeapon, Constants.XML_EQUIPMENT_WEAPON_SLOT, weapon.weaponSlot);
            
            return xmlWeapon;
        }

        private static void addXmlChild(XElement xmlParent, XElement xmlChild)
        {
            xmlParent.Add(xmlChild);
        }

        private static void addBaseChild(XElement xmlParent, string childContent, string childValue)
        {
            xmlParent.Add(new XElement(childContent));
            xmlParent.Element(childContent).Value = childValue;
        }
    }
}
