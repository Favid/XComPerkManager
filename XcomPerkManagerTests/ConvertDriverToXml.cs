using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XcomPerkManager.DataObjects;
using System.Xml.Linq;
using XcomPerkManager;
using System.Collections.Generic;

namespace XcomPerkManagerTests
{
    [TestClass]
    public class ConvertDriverToXml
    {
        [TestMethod]
        public void convertMetadata()
        {
            SoldierClassMetadata metadata = new SoldierClassMetadata();
            metadata.internalName = "InternalTest";
            metadata.displayName = "Internal Test";
            metadata.description = "This is a test";
            metadata.iconString = "Here.jpg";

            XElement actual = XcomPerkManager.Conversion.Convert.toXmlMetadata(metadata);

            XElement expected = new XElement(Constants.XML_METADATA);
            expected.Add(new XElement(Constants.XML_METADATA_INTERNAL_NAME, "InternalTest"));
            expected.Add(new XElement(Constants.XML_METADATA_DISPLAY_NAME, "Internal Test"));
            expected.Add(new XElement(Constants.XML_METADATA_DESCRIPTION, "This is a test"));
            expected.Add(new XElement(Constants.XML_METADATA_ICON_STRING, "Here.jpg"));

            Assert.IsTrue(XNode.DeepEquals(expected, actual), "Expected: " + expected.ToString() + "\nActual: " + actual.ToString());
        }

        [TestMethod]
        public void convertEquipment()
        {
            SoldierClassEquipment equipment = new SoldierClassEquipment();
            equipment.squaddieLoadout = "Squaddie_TestClass";
            equipment.allowedArmors = "squaddie";
            
            List<Weapon> weapons = new List<Weapon>();

            Weapon weaponA = new Weapon();
            weaponA.weaponName = "shotgun";
            weaponA.weaponSlot = "primary";        // TODO verify if it should be primary or eInv_PrimaryWeapon
            weapons.Add(weaponA);

            Weapon weaponB = new Weapon();
            weaponB.weaponName = "sword";
            weaponB.weaponSlot = "secondary";        // TODO verify if it should be primary or eInv_PrimaryWeapon
            weapons.Add(weaponB);

            equipment.weapons = weapons;

            XElement actual = XcomPerkManager.Conversion.Convert.toXmlEquipment(equipment);

            XElement expected = new XElement(Constants.XML_EQUIPMENT);
            expected.Add(new XElement(Constants.XML_EQUIPMENT_SQUADDIE_LOADOUT, "Squaddie_TestClass"));
            expected.Add(new XElement(Constants.XML_EQUIPMENT_ALLOWED_ARMORS, "squaddie"));

            XElement expectedWeapons = new XElement(Constants.XML_EQUIPMENT_WEAPONS);

            XElement expectedWeaponA = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            expectedWeaponA.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "shotgun"));
            expectedWeaponA.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "primary"));
            expectedWeapons.Add(expectedWeaponA);

            XElement expectedWeaponB = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            expectedWeaponB.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "sword"));
            expectedWeaponB.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "secondary"));
            expectedWeapons.Add(expectedWeaponB);

            expected.Add(expectedWeapons);

            Assert.IsTrue(XNode.DeepEquals(expected, actual), "Expected: " + expected.ToString() + "\nActual: " + actual.ToString());
        }

        [TestMethod]
        public void convertWeapons()
        {
            List<Weapon> weapons = new List<Weapon>();
            
            Weapon weaponA = new Weapon();
            weaponA.weaponName = "shotgun";
            weaponA.weaponSlot = "primary";        // TODO verify if it should be primary or eInv_PrimaryWeapon
            weapons.Add(weaponA);

            Weapon weaponB = new Weapon();
            weaponB.weaponName = "sword";
            weaponB.weaponSlot = "secondary";        // TODO verify if it should be primary or eInv_PrimaryWeapon
            weapons.Add(weaponB);

            XElement actual = XcomPerkManager.Conversion.Convert.toXmlWeapons(weapons);

            XElement expected = new XElement(Constants.XML_EQUIPMENT_WEAPONS);

            XElement expectedWeaponA = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            expectedWeaponA.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "shotgun"));
            expectedWeaponA.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "primary"));
            expected.Add(expectedWeaponA);

            XElement expectedWeaponB = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            expectedWeaponB.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "sword"));
            expectedWeaponB.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "secondary"));
            expected.Add(expectedWeaponB);

            Assert.IsTrue(XNode.DeepEquals(expected, actual));
        }

        [TestMethod]
        public void convertWeapon()
        {
            Weapon weapon = new Weapon();
            weapon.weaponName = "shotgun";
            weapon.weaponSlot = "primary";        // TODO verify if it should be primary or eInv_PrimaryWeapon

            XElement actual = XcomPerkManager.Conversion.Convert.toXmlWeapon(weapon);

            XElement expected = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            expected.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "shotgun"));
            expected.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "primary"));

            Assert.IsTrue(XNode.DeepEquals(expected, actual));
        }
    }
}
