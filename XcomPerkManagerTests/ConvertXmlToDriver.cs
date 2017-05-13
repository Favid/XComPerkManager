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
        public void convertExperience()
        {
            XElement xmlExperience = new XElement(Constants.XML_EXPERIENCE);
            xmlExperience.Add(new XElement(Constants.XML_EXPERIENCE_NUM_IN_FORCED_DECK, "1"));
            xmlExperience.Add(new XElement(Constants.XML_EXPERIENCE_NUM_IN_DECK, "2"));
            xmlExperience.Add(new XElement(Constants.XML_EXPERIENCE_KILL_ASSISTS_PER_KILL, "3"));

            SoldierClassExperience actual = XcomPerkManager.Conversion.Convert.toDriverExperience(xmlExperience);

            SoldierClassExperience expected = new SoldierClassExperience();
            expected.numberInForcedDeck = 1;
            expected.numberInDeck = 2;
            expected.killAssistsPerKill = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertEquipment()
        {
            XElement xmlWeapons = new XElement(Constants.XML_EQUIPMENT_WEAPONS);

            XElement xmlWeaponA = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            xmlWeaponA.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "shotgun"));
            xmlWeaponA.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "2"));
            xmlWeapons.Add(xmlWeaponA);

            XElement xmlWeaponB = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            xmlWeaponB.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "sword"));
            xmlWeaponB.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "3"));
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
            expectedWeaponA.weaponSlot =  WeaponSlot.Primary;
            expectedWeapons.Add(expectedWeaponA);

            Weapon expectedWeaponB = new Weapon();
            expectedWeaponB.weaponName = "sword";
            expectedWeaponB.weaponSlot = WeaponSlot.Secondary;
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
            xmlWeaponA.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "2"));
            xmlWeapons.Add(xmlWeaponA);

            XElement xmlWeaponB = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            xmlWeaponB.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "sword"));
            xmlWeaponB.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "3"));
            xmlWeapons.Add(xmlWeaponB);
            
            List<Weapon> actual = XcomPerkManager.Conversion.Convert.toDriverWeapons(xmlWeapons);

            List<Weapon> expected = new List<Weapon>();

            Weapon expectedWeaponA = new Weapon();
            expectedWeaponA.weaponName = "shotgun";
            expectedWeaponA.weaponSlot = WeaponSlot.Primary;
            expected.Add(expectedWeaponA);

            Weapon expectedWeaponB = new Weapon();
            expectedWeaponB.weaponName = "sword";
            expectedWeaponB.weaponSlot = WeaponSlot.Secondary;
            expected.Add(expectedWeaponB);
            
            Assert.IsTrue(expected.SequenceEqual(actual), "Expected: " + expected.ToString() + "\nActual: " + actual.ToString());
        }

        [TestMethod]
        public void convertWeapon()
        {
            XElement xmlWeapon = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            xmlWeapon.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "shotgun"));
            xmlWeapon.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "2"));

            Weapon actual = XcomPerkManager.Conversion.Convert.toDriverWeapon(xmlWeapon);
            Weapon expected = new Weapon();
            expected.weaponName = "shotgun";
            expected.weaponSlot = WeaponSlot.Primary;
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertAbilities()
        {
            XElement xmlAbilities = new XElement(Constants.XML_ABILITIES);

            XElement xmlAbilityA = new XElement(Constants.XML_ABILITY);
            xmlAbilityA.Add(new XElement(Constants.XML_ABILITY_INTERNAL_NAME, "Squadsight"));
            xmlAbilityA.Add(new XElement(Constants.XML_ABILITY_RANK, "2"));
            xmlAbilityA.Add(new XElement(Constants.XML_ABILITY_SLOT, "3"));
            xmlAbilities.Add(xmlAbilityA);

            XElement xmlAbilityB = new XElement(Constants.XML_ABILITY);
            xmlAbilityB.Add(new XElement(Constants.XML_ABILITY_INTERNAL_NAME, "IntrusionProtocol"));
            xmlAbilityB.Add(new XElement(Constants.XML_ABILITY_RANK, "4"));
            xmlAbilityB.Add(new XElement(Constants.XML_ABILITY_SLOT, "1"));
            xmlAbilities.Add(xmlAbilityB);
            
            List<SoldierClassAbility> actual = XcomPerkManager.Conversion.Convert.toDriverAbilities(xmlAbilities);

            List<SoldierClassAbility> expected = new List<SoldierClassAbility>();
            
            SoldierClassAbility expectedAbilityA = new SoldierClassAbility();
            expectedAbilityA.internalName = "Squadsight";
            expectedAbilityA.displayName = "Squadsight";
            expectedAbilityA.description = "You can target enemies within squadmates' sight, provided there is line of sight to the target.";
            expectedAbilityA.requiredMod = "None";
            expectedAbilityA.rank = SoldierRank.Corporal;
            expectedAbilityA.slot = 3;
            expectedAbilityA.weaponSlot = WeaponSlot.None;
            expected.Add(expectedAbilityA);

            SoldierClassAbility expectedAbilityB = new SoldierClassAbility();
            expectedAbilityB.internalName = "IntrusionProtocol";
            expectedAbilityB.displayName = "Hack";
            expectedAbilityB.description = "Attempt to remotely breach security on a network access point with your GREMLIN.";
            expectedAbilityB.requiredMod = "None";
            expectedAbilityB.rank = SoldierRank.Lieutenant;
            expectedAbilityB.slot = 1;
            expectedAbilityB.weaponSlot = WeaponSlot.Secondary;
            expected.Add(expectedAbilityB);

            Assert.IsTrue(expected.SequenceEqual(actual), "Expected: " + expected.ToString() + "\nActual: " + actual.ToString());
        }

        [TestMethod]
        public void convertAbility()
        {
            XElement xmlAbility = new XElement(Constants.XML_ABILITY);
            xmlAbility.Add(new XElement(Constants.XML_ABILITY_INTERNAL_NAME, "Squadsight"));
            xmlAbility.Add(new XElement(Constants.XML_ABILITY_RANK, "2"));
            xmlAbility.Add(new XElement(Constants.XML_ABILITY_SLOT, "3"));

            SoldierClassAbility actual = XcomPerkManager.Conversion.Convert.toDriverAbility(xmlAbility);
            SoldierClassAbility expected = new SoldierClassAbility();
            expected.internalName = "Squadsight";
            expected.displayName = "Squadsight";
            expected.description = "You can target enemies within squadmates' sight, provided there is line of sight to the target.";
            expected.requiredMod = "None";
            expected.rank = SoldierRank.Corporal;
            expected.slot = 3;
            expected.weaponSlot = WeaponSlot.None;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void convertStats()
        {
            XElement xmlStats = new XElement(Constants.XML_STATS);

            XElement xmlStatA = new XElement(Constants.XML_ABILITY);
            xmlStatA.Add(new XElement(Constants.XML_STAT_TYPE, "2"));
            xmlStatA.Add(new XElement(Constants.XML_STAT_VALUE, "2"));
            xmlStatA.Add(new XElement(Constants.XML_STAT_RANK, "3"));
            xmlStats.Add(xmlStatA);

            XElement xmlStatB = new XElement(Constants.XML_ABILITY);
            xmlStatB.Add(new XElement(Constants.XML_STAT_TYPE, "1"));
            xmlStatB.Add(new XElement(Constants.XML_STAT_VALUE, "0"));
            xmlStatB.Add(new XElement(Constants.XML_STAT_RANK, "1"));
            xmlStats.Add(xmlStatB);

            List<SoldierClassStat> actual = XcomPerkManager.Conversion.Convert.toDriverStats(xmlStats);

            List<SoldierClassStat> expected = new List<SoldierClassStat>();

            SoldierClassStat expectedStatA = new SoldierClassStat();
            expectedStatA.stat = Stat.Strength;
            expectedStatA.value = 2;
            expectedStatA.rank = SoldierRank.Sergeant;
            expected.Add(expectedStatA);

            SoldierClassStat expectedStatB = new SoldierClassStat();
            expectedStatB.stat = Stat.Aim;
            expectedStatB.value = 0;
            expectedStatB.rank = SoldierRank.Squaddie;
            expected.Add(expectedStatB);

            Assert.IsTrue(expected.SequenceEqual(actual), "Expected: " + expected.ToString() + "\nActual: " + actual.ToString());
        }

        [TestMethod]
        public void convertStat()
        {
            XElement xmlStat = new XElement(Constants.XML_STAT);
            xmlStat.Add(new XElement(Constants.XML_STAT_TYPE, "2"));
            xmlStat.Add(new XElement(Constants.XML_STAT_VALUE, "2"));
            xmlStat.Add(new XElement(Constants.XML_STAT_RANK, "3"));

            SoldierClassStat actual = XcomPerkManager.Conversion.Convert.toDriverStat(xmlStat);

            SoldierClassStat expected = new SoldierClassStat();
            expected.stat = Stat.Strength;
            expected.value = 2;
            expected.rank = SoldierRank.Sergeant;
            
            Assert.AreEqual(expected, actual, "Expected: " + expected.ToString() + "\nActual: " + actual.ToString());
        }
    }
}
