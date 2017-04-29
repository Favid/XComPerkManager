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
