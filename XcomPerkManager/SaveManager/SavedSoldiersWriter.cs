using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace XcomPerkManager
{
    public class SavedSoldiersWriter
    {
        private string fullPath;
        private XDocument document;
        private List<Ability> allAbilities;

        public SavedSoldiersWriter(List<Ability> abilities)
        {
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(currentDir);
            DirectoryInfo root = directory.Parent.Parent;
            fullPath = Path.Combine(root.FullName, "SavedSoldiers.xml");

            document = XDocument.Load(fullPath);
            allAbilities = abilities;
        }

        public void addClass(SoldierClass soldierClass)
        {
            XElement parentElement = document.Element(Constants.XML_CLASSES);


        }

        public void updateClassMetadata(string formerInternalName, SoldierClassMetadata metadata)
        {
            XElement parentElement = document.Element(Constants.XML_CLASSES);
            List<XElement> soldierElements = parentElement.Elements(Constants.XML_CLASS).ToList();

            foreach (XElement soldierElement in soldierElements)
            {
                XElement metadataElement = soldierElement.Element("metadata");

                if(metadataElement.Element("internal_name").Value.Equals(formerInternalName))
                {
                    metadataElement.Element("internal_name").Value = metadata.internalName;
                    metadataElement.Element("display_name").Value = metadata.displayName;
                    metadataElement.Element("description").Value = metadata.description;
                    metadataElement.Element("icon_string").Value = metadata.iconString;
                    
                    break;
                }
            }

            document.Save(fullPath);
        }

        public void updateClassExperience(string formerInternalName, SoldierClassExperience experience)
        {
            XElement parentElement = document.Element(Constants.XML_CLASSES);
            List<XElement> soldierElements = parentElement.Elements(Constants.XML_CLASS).ToList();

            foreach (XElement soldierElement in soldierElements)
            {
                XElement metadataElement = soldierElement.Element("metadata");

                if (metadataElement.Element("internal_name").Value.Equals(formerInternalName))
                {
                    XElement experienceElement = soldierElement.Element("experience");
                    experienceElement.Element("number_in_forced_deck").Value = experience.numberInForcedDeck.ToString();
                    experienceElement.Element("number_in_deck").Value = experience.numberInDeck.ToString();
                    experienceElement.Element("kill_assists_per_kill").Value = experience.killAssistsPerKill.ToString();

                    break;
                }
            }

            document.Save(fullPath);
        }

        public void updateClassEquipment(string formerInternalName, SoldierClassEquipment equipment)
        {
            XElement parentElement = document.Element(Constants.XML_CLASSES);
            List<XElement> soldierElements = parentElement.Elements(Constants.XML_CLASS).ToList();

            foreach (XElement soldierElement in soldierElements)
            {
                XElement metadataElement = soldierElement.Element("metadata");

                if (metadataElement.Element("internal_name").Value.Equals(formerInternalName))
                {
                    XElement experienceElement = soldierElement.Element("equipment");
                    experienceElement.Element("squaddie_loadout").Value = equipment.squaddieLoadout;
                    experienceElement.Element("primary_weapon").Value = equipment.primaryWeapon;
                    experienceElement.Element("secondary_weapon").Value = equipment.secondaryWeapon;
                    experienceElement.Element("allowed_armors").Value = equipment.allowedArmors;

                    break;
                }
            }

            document.Save(fullPath);
        }

        public void updateClassAbilities(string formerInternalName, List<SoldierClassAbility> soldierAbilities)
        {
            XElement parentElement = document.Element(Constants.XML_CLASSES);
            List<XElement> soldierElements = parentElement.Elements(Constants.XML_CLASS).ToList();

            foreach (XElement soldierElement in soldierElements)
            {
                XElement metadataElement = soldierElement.Element("metadata");

                if (metadataElement.Element("internal_name").Value.Equals(formerInternalName))
                {
                    XElement abilitiesElement = soldierElement.Element("abilities");

                    List<XElement> abilityElements = abilitiesElement.Elements("ability").ToList();

                    foreach(SoldierClassAbility soldierAbility in soldierAbilities)
                    {
                        bool found = false;

                        foreach(XElement abilityElement in abilityElements)
                        {
                            XElement rankElement = abilityElement.Element("rank");
                            XElement slotElement = abilityElement.Element("slot");

                            int rankElementInt = int.Parse(rankElement.Value);
                            int slotElementInt = int.Parse(slotElement.Value);

                            if(slotElementInt == soldierAbility.slot && rankElementInt == (int)soldierAbility.rank)
                            {
                                found = true;
                                abilityElement.Element("internal_name").Value = soldierAbility.internalName;
                                break;
                            }
                        }

                        if(!found)
                        {
                            XElement newAbilityInternalName = new XElement("internal_name", soldierAbility.internalName);
                            XElement newAbilityRank = new XElement("rank", (int)soldierAbility.rank);
                            XElement newAbilitySlot = new XElement("slot", soldierAbility.slot);

                            XElement newAbility = new XElement("ability", newAbilityInternalName, newAbilityRank, newAbilitySlot);
                            abilitiesElement.Add(newAbility);
                        }
                    }
                    
                    break;
                }
            }

            document.Save(fullPath);
        }

        public void updateClassStats(string formerInternalName, List<SoldierClassStat> soldierStats)
        {
            XElement parentElement = document.Element(Constants.XML_CLASSES);
            List<XElement> soldierElements = parentElement.Elements(Constants.XML_CLASS).ToList();

            foreach (XElement soldierElement in soldierElements)
            {
                XElement metadataElement = soldierElement.Element("metadata");

                if (metadataElement.Element("internal_name").Value.Equals(formerInternalName))
                {
                    XElement statsElement = soldierElement.Element("stats");

                    List<XElement> statElements = statsElement.Elements("stat").ToList();

                    foreach (SoldierClassStat soldierStat in soldierStats)
                    {
                        foreach (XElement statElement in statElements)
                        {
                            XElement rankElement = statElement.Element("rank");
                            XElement typeElement = statElement.Element("type");

                            int rankElementInt = int.Parse(rankElement.Value);
                            int typeElementInt = int.Parse(typeElement.Value);

                            if (typeElementInt == (int)soldierStat.stat && rankElementInt == (int)soldierStat.rank)
                            {
                                statElement.Element("value").Value = soldierStat.value.ToString();
                                break;
                            }
                        }
                    }

                    break;
                }
            }

            document.Save(fullPath);
        }
    }
}
