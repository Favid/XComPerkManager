using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XcomPerkManager
{
    public class SavedSoldiersReader
    {
        private XDocument document;
        private List<Ability> allAbilities;

        public SavedSoldiersReader(List<Ability> abilities)
        {
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(currentDir);
            DirectoryInfo root = directory.Parent.Parent;
            string fullPath = Path.Combine(root.FullName, "SavedSoldiers.xml");

            document = XDocument.Load(fullPath);
            allAbilities = abilities;
        }

        public List<SoldierClass> read()
        {
            List<SoldierClass> classes = new List<SoldierClass>();

            XElement parentElement = document.Element(Constants.XML_CLASSES);
            List<XElement> soldierElements = parentElement.Elements(Constants.XML_CLASS).ToList();

            foreach(XElement soldierElement in soldierElements)
            {
                SoldierClass soldierClass = new SoldierClass();
                soldierClass.metadata = readMetadata(soldierElement.Element("metadata"));
                soldierClass.experience = readExperience(soldierElement.Element("experience"));
                soldierClass.equipment = readEquipment(soldierElement.Element("equipment"));
                soldierClass.soldierAbilities = readAbilities(soldierElement.Element("abilities"));
                soldierClass.stats = readStats(soldierElement.Element("stats"));

                classes.Add(soldierClass);
            }

            return classes;
        }

        private SoldierClassMetadata readMetadata(XElement metadataElement)
        {
            SoldierClassMetadata metadata = new SoldierClassMetadata();
            metadata.internalName = metadataElement.Element("internal_name").Value;
            metadata.displayName = metadataElement.Element("display_name").Value;
            metadata.description = metadataElement.Element("description").Value;
            metadata.iconString = metadataElement.Element("icon_string").Value;

            return metadata;
        }

        private SoldierClassExperience readExperience(XElement experienceElement)
        {
            SoldierClassExperience experience = new SoldierClassExperience();
            experience.numberInForcedDeck = Utils.parseStringToInt(experienceElement.Element("number_in_forced_deck").Value);
            experience.numberInDeck = Utils.parseStringToInt(experienceElement.Element("number_in_deck").Value);
            experience.killAssistsPerKill = Utils.parseStringToInt(experienceElement.Element("kill_assists_per_kill").Value);

            return experience;
        }

        private SoldierClassEquipment readEquipment(XElement equipmentElement)
        {
            SoldierClassEquipment equipment = new SoldierClassEquipment();
            equipment.squaddieLoadout = equipmentElement.Element("squaddie_loadout").Value;
            equipment.primaryWeapon = equipmentElement.Element("primary_weapon").Value;
            equipment.secondaryWeapon = equipmentElement.Element("secondary_weapon").Value;
            equipment.allowedArmors = equipmentElement.Element("allowed_armors").Value;

            return equipment;
        }

        private List<SoldierClassAbility> readAbilities(XElement abilitiesElement)
        {
            List<SoldierClassAbility> abilities = new List<SoldierClassAbility>();

            List<XElement> abilityElements = abilitiesElement.Elements("ability").ToList();
            foreach (XElement abilityElement in abilityElements)
            {
                SoldierClassAbility soldierAbility = readAbility(abilityElement);

                if(soldierAbility != null)
                {
                    abilities.Add(soldierAbility);
                }
            }

            return abilities;
        }

        private SoldierClassAbility readAbility(XElement abilityElement)
        {
            SoldierClassAbility soldierClassAbility = null;
            
            string internalName = abilityElement.Element("internal_name").Value;
            Ability ability = allAbilities.Where(x => x.internalName.Equals(internalName)).FirstOrDefault();

            if(ability != null)
            {
                soldierClassAbility = new SoldierClassAbility(ability);
                soldierClassAbility.rank = (SoldierRank)Utils.parseStringToInt(abilityElement.Element("rank").Value);
                soldierClassAbility.slot = Utils.parseStringToInt(abilityElement.Element("slot").Value);
            }

            return soldierClassAbility;
        }

        public List<SoldierClassStat> readStats(XElement statsElement)
        {
            List<SoldierClassStat> stats = new List<SoldierClassStat>();

            List<XElement> statElements = statsElement.Elements("stat").ToList();
            foreach (XElement statElement in statElements)
            {
                SoldierClassStat soldierStat = readStat(statElement);

                if (soldierStat != null)
                {
                    stats.Add(soldierStat);
                }
            }

            return stats;
        }

        public SoldierClassStat readStat(XElement statElement)
        {
            SoldierClassStat soldierClassStat = new SoldierClassStat();

            soldierClassStat.stat = (Stat)Utils.parseStringToInt(statElement.Element("type").Value);
            soldierClassStat.rank = (SoldierRank)Utils.parseStringToInt(statElement.Element("rank").Value);
            soldierClassStat.value = Utils.parseStringToInt(statElement.Element("value").Value);
            
            return soldierClassStat;
        }
    }
}
