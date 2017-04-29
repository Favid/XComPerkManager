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
        public void convertExperience()
        {
            SoldierClassExperience experience = new SoldierClassExperience();
            experience.numberInForcedDeck = 1;
            experience.numberInDeck = 2;
            experience.killAssistsPerKill = 3;

            XElement actual = XcomPerkManager.Conversion.Convert.toXmlExperience(experience);

            XElement expected = new XElement(Constants.XML_EXPERIENCE);
            expected.Add(new XElement(Constants.XML_EXPERIENCE_NUM_IN_FORCED_DECK, "1"));
            expected.Add(new XElement(Constants.XML_EXPERIENCE_NUM_IN_DECK, "2"));
            expected.Add(new XElement(Constants.XML_EXPERIENCE_KILL_ASSISTS_PER_KILL, "3"));

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

        [TestMethod]
        public void convertAbilities()
        {
            List<SoldierClassAbility> abilities = new List<SoldierClassAbility>();

            SoldierClassAbility abilityA = new SoldierClassAbility();
            abilityA.internalName = "TestAbility";
            abilityA.displayName = "Test Ability";
            abilityA.description = "Hello";
            abilityA.requiredMod = "My Mod";
            abilityA.rank = SoldierRank.Corporal;
            abilityA.slot = 3;
            abilityA.weaponSlot = WeaponSlot.Primary;
            abilities.Add(abilityA);

            SoldierClassAbility abilityB = new SoldierClassAbility();
            abilityB.internalName = "TestAbility2";
            abilityB.displayName = "Test Ability2";
            abilityB.description = "Hello2";
            abilityB.requiredMod = "My Mod2";
            abilityB.rank = SoldierRank.Lieutenant;
            abilityB.slot = 1;
            abilityB.weaponSlot = WeaponSlot.Secondary;
            abilities.Add(abilityB);

            XElement actual = XcomPerkManager.Conversion.Convert.toXmlAbilities(abilities);

            XElement expected = new XElement(Constants.XML_ABILITIES);

            XElement expectedAbilityA = new XElement(Constants.XML_ABILITY);
            expectedAbilityA.Add(new XElement(Constants.XML_ABILITY_INTERNAL_NAME, "TestAbility"));
            expectedAbilityA.Add(new XElement(Constants.XML_ABILITY_RANK, "2"));
            expectedAbilityA.Add(new XElement(Constants.XML_ABILITY_SLOT, "3"));
            expected.Add(expectedAbilityA);

            XElement expectedAbilityB = new XElement(Constants.XML_ABILITY);
            expectedAbilityB.Add(new XElement(Constants.XML_ABILITY_INTERNAL_NAME, "TestAbility2"));
            expectedAbilityB.Add(new XElement(Constants.XML_ABILITY_RANK, "4"));
            expectedAbilityB.Add(new XElement(Constants.XML_ABILITY_SLOT, "1"));
            expected.Add(expectedAbilityB);

            Assert.IsTrue(XNode.DeepEquals(expected, actual), "Expected: " + expected.ToString() + "\nActual: " + actual.ToString());
        }

        [TestMethod]
        public void convertAbility()
        {
            SoldierClassAbility ability = new SoldierClassAbility();
            ability.internalName = "TestAbility";
            ability.displayName = "Test Ability";
            ability.description = "Hello";
            ability.requiredMod = "My Mod";
            ability.rank = SoldierRank.Corporal;
            ability.slot = 3;
            ability.weaponSlot = WeaponSlot.Primary;

            XElement actual = XcomPerkManager.Conversion.Convert.toXmlAbility(ability);

            XElement expected = new XElement(Constants.XML_ABILITY);
            expected.Add(new XElement(Constants.XML_ABILITY_INTERNAL_NAME, "TestAbility"));
            expected.Add(new XElement(Constants.XML_ABILITY_RANK, "2"));
            expected.Add(new XElement(Constants.XML_ABILITY_SLOT, "3"));

            Assert.IsTrue(XNode.DeepEquals(expected, actual), "Expected: " + expected.ToString() + "\nActual: " + actual.ToString());
        }

        [TestMethod]
        public void convertStats()
        {
            List<SoldierClassStat> stats = new List<SoldierClassStat>();

            SoldierClassStat statA = new SoldierClassStat();
            statA.stat = Stat.Strength;
            statA.value = 2;
            statA.rank = SoldierRank.Sergeant;
            stats.Add(statA);

            SoldierClassStat statB = new SoldierClassStat();
            statB.stat = Stat.Aim;
            statB.value = 0;
            statB.rank = SoldierRank.Squaddie;
            stats.Add(statB);

            XElement actual = XcomPerkManager.Conversion.Convert.toXmlStats(stats);

            XElement expected = new XElement(Constants.XML_STATS);

            XElement expectedStatA = new XElement(Constants.XML_STAT);
            expectedStatA.Add(new XElement(Constants.XML_STAT_TYPE, "2"));
            expectedStatA.Add(new XElement(Constants.XML_STAT_VALUE, "2"));
            expectedStatA.Add(new XElement(Constants.XML_STAT_RANK, "3"));
            expected.Add(expectedStatA);

            XElement expectedStatB = new XElement(Constants.XML_STAT);
            expectedStatB.Add(new XElement(Constants.XML_STAT_TYPE, "1"));
            expectedStatB.Add(new XElement(Constants.XML_STAT_VALUE, "0"));
            expectedStatB.Add(new XElement(Constants.XML_STAT_RANK, "1"));
            expected.Add(expectedStatB);

            Assert.IsTrue(XNode.DeepEquals(expected, actual), "Expected: " + expected.ToString() + "\nActual: " + actual.ToString());
        }

        [TestMethod]
        public void convertStat()
        {
            SoldierClassStat stat = new SoldierClassStat();
            stat.stat = Stat.Strength;
            stat.value = 2;
            stat.rank = SoldierRank.Sergeant;

            XElement actual = XcomPerkManager.Conversion.Convert.toXmlStat(stat);

            XElement expected = new XElement(Constants.XML_STAT);
            expected.Add(new XElement(Constants.XML_STAT_TYPE, "2"));
            expected.Add(new XElement(Constants.XML_STAT_VALUE, "2"));
            expected.Add(new XElement(Constants.XML_STAT_RANK, "3"));

            Assert.IsTrue(XNode.DeepEquals(expected, actual));
        }
    }
}
