using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XcomPerkManager.DataObjects;
using System.Xml.Linq;
using XcomPerkManager;
using System.Collections.Generic;
using System.Linq;

namespace XcomPerkManagerTests
{
    [TestClass]
    public class ConvertXmlToDriver
    {
        [TestMethod]
        public void convertMetadata()
        {
            XElement xmlMetadata = new XElement(Constants.XML_METADATA);
            xmlMetadata.Add(new XElement(Constants.XML_METADATA_INTERNAL_NAME, "InternalTest"));
            xmlMetadata.Add(new XElement(Constants.XML_METADATA_DISPLAY_NAME, "Internal Test"));
            xmlMetadata.Add(new XElement(Constants.XML_METADATA_DESCRIPTION, "This is a test"));
            xmlMetadata.Add(new XElement(Constants.XML_METADATA_ICON_STRING, "Here.jpg"));

            SoldierClassMetadata actual = XcomPerkManager.Conversion.Convert.toDriverMetadata(xmlMetadata);

            SoldierClassMetadata expected = new SoldierClassMetadata();
            expected.internalName = "InternalTest";
            expected.displayName = "Internal Test";
            expected.description = "This is a test";
            expected.iconString = "Here.jpg";
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertEquipment()
        {
            XElement xmlWeapons = new XElement(Constants.XML_EQUIPMENT_WEAPONS);

            XElement xmlWeaponA = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            xmlWeaponA.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "shotgun"));
            xmlWeaponA.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "primary"));
            xmlWeapons.Add(xmlWeaponA);

            XElement xmlWeaponB = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            xmlWeaponB.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "sword"));
            xmlWeaponB.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "secondary"));
            xmlWeapons.Add(xmlWeaponB);

            XElement xmlEquipment = new XElement(Constants.XML_EQUIPMENT);
            xmlEquipment.Add(new XElement(Constants.XML_EQUIPMENT_SQUADDIE_LOADOUT, "Squaddie_TestClass"));
            xmlEquipment.Add(new XElement(Constants.XML_EQUIPMENT_ALLOWED_ARMORS, "squaddie"));
            xmlEquipment.Add(xmlWeapons);

            SoldierClassEquipment actual = XcomPerkManager.Conversion.Convert.toDriverEquipment(xmlEquipment);

            SoldierClassEquipment expected = new SoldierClassEquipment();
            expected.squaddieLoadout = "Squaddie_TestClass";
            expected.allowedArmors = "squaddie";

            List<Weapon> expectedWeapons = new List<Weapon>();

            Weapon expectedWeaponA = new Weapon();
            expectedWeaponA.weaponName = "shotgun";
            expectedWeaponA.weaponSlot = "primary";
            expectedWeapons.Add(expectedWeaponA);

            Weapon expectedWeaponB = new Weapon();
            expectedWeaponB.weaponName = "sword";
            expectedWeaponB.weaponSlot = "secondary";
            expectedWeapons.Add(expectedWeaponB);

            expected.weapons = expectedWeapons;

            Assert.AreEqual(expected, actual, "Expected: " + expected.ToString() + "\nActual: " + actual.ToString());
        }

        [TestMethod]
        public void convertWeapons()
        {
            XElement xmlWeapons = new XElement(Constants.XML_EQUIPMENT_WEAPONS);

            XElement xmlWeaponA = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            xmlWeaponA.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "shotgun"));
            xmlWeaponA.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "primary"));
            xmlWeapons.Add(xmlWeaponA);

            XElement xmlWeaponB = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            xmlWeaponB.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "sword"));
            xmlWeaponB.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "secondary"));
            xmlWeapons.Add(xmlWeaponB);
            
            List<Weapon> actual = XcomPerkManager.Conversion.Convert.toDriverWeapons(xmlWeapons);

            List<Weapon> expected = new List<Weapon>();

            Weapon expectedWeaponA = new Weapon();
            expectedWeaponA.weaponName = "shotgun";
            expectedWeaponA.weaponSlot = "primary";
            expected.Add(expectedWeaponA);

            Weapon expectedWeaponB = new Weapon();
            expectedWeaponB.weaponName = "sword";
            expectedWeaponB.weaponSlot = "secondary";
            expected.Add(expectedWeaponB);
            
            Assert.IsTrue(expected.SequenceEqual(actual), "Expected: " + expected.ToString() + "\nActual: " + actual.ToString());
        }

        [TestMethod]
        public void convertWeapon()
        {
            XElement xmlWeapon = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            xmlWeapon.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "shotgun"));
            xmlWeapon.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "primary"));

            Weapon actual = XcomPerkManager.Conversion.Convert.toDriverWeapon(xmlWeapon);
            Weapon expected = new Weapon();
            expected.weaponName = "shotgun";
            expected.weaponSlot = "primary";        // TODO verify if it should be primary or eInv_PrimaryWeapon
            
            Assert.AreEqual(expected, actual);
        }
    }
}
