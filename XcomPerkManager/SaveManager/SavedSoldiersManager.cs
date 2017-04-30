using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XcomPerkManager
{
    public class SavedSoldiersManager
    {
        private string fullPath;
        private XDocument document;

        public SavedSoldiersManager()
        {
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(currentDir);
            DirectoryInfo root = directory.Parent.Parent;
            fullPath = Path.Combine(root.FullName, "SavedSoldiers.xml");

            document = XDocument.Load(fullPath);
        }

        public List<SoldierClass> loadAllSoldierClasses()
        {
            XElement xmlSoldierClasses = document.Element(Constants.XML_CLASSES);
            return Conversion.Convert.toDriverSoldierClasses(xmlSoldierClasses);
        }

        public SoldierClass addNewSoldierClass()
        {
            SoldierClass soldierClass = new SoldierClass();
            soldierClass.metadata.internalName = getNewName();
            soldierClass.metadata.displayName = soldierClass.metadata.internalName;

            XElement xmlSoldierClass = Conversion.Convert.toXmlSoldierClass(soldierClass);
            
            XElement xmlClasses = getXmlClasses();
            xmlClasses.Add(xmlSoldierClass);
            
            document.Save(fullPath);

            return soldierClass;
        }

        private string getNewName()
        {
            string name = "New";

            if (validName(name))
            {
                return name;
            }

            for (int i = 1; i < 999; i++)
            {
                string workingName = name += i.ToString();

                if (validName(workingName))
                {
                    return workingName;
                }
            }

            throw new ApplicationException("You need to delete some of those 'New' classes...");
        }

        private bool validName(string name)
        {
            List<XElement> classElements = document
                .Element(Constants.XML_CLASSES)
                .Elements(Constants.XML_CLASS)
                .ToList();

            foreach (XElement classElement in classElements)
            {
                string internalClassName = classElement
                    .Element(Constants.XML_METADATA)
                    .Element(Constants.XML_METADATA_INTERNAL_NAME)
                    .Value;

                if (name == internalClassName)
                {
                    return false;
                }
            }

            return true;
        }

        public bool saveMetadata(string internalName, SoldierClassMetadata metadata)
        {
            XElement xmlMetadata = getClassElement(internalName, Constants.XML_METADATA);
            XElement newXmlMetadata = new XElement(Conversion.Convert.toXmlMetadata(metadata));
            xmlMetadata.ReplaceWith(newXmlMetadata);
            document.Save(fullPath);
            return true;
        }

        public bool saveEquipment(string internalName, SoldierClassEquipment equipment)
        {
            XElement xmlEquipment = getClassElement(internalName, Constants.XML_EQUIPMENT);
            XElement newXmlEquipment = new XElement(Conversion.Convert.toXmlEquipment(equipment));
            xmlEquipment.ReplaceWith(newXmlEquipment);
            document.Save(fullPath);
            return true;
        }

        public XElement getXmlClasses()
        {
            return document.Element(Constants.XML_CLASSES);
        }

        public XElement getXmlClass(String internalName)
        {
            XElement documentElement = document
                .Element(Constants.XML_CLASSES)
                .Elements(Constants.XML_CLASS)
                .Where(x => x.Element(Constants.XML_METADATA)
                .Element(Constants.XML_METADATA_INTERNAL_NAME)
                .Value == internalName)
                .Single();

            return documentElement;
        }

        public XElement getClassElement(string internalName, string xmlClassElementTag)
        {
            XElement documentElement = document
                .Element(Constants.XML_CLASSES)
                .Elements(Constants.XML_CLASS)
                .Where(x => x.Element(Constants.XML_METADATA)
                .Element(Constants.XML_METADATA_INTERNAL_NAME)
                .Value == internalName)
                .Single()
                .Element(xmlClassElementTag);

            return documentElement;
        }

        public bool updateClassElement(string internalName, ISoldierClassElement element, string xmlClassElementTag)
        {
            if (!element.allowUpdate().valid)
            {
                return false;
            }

            XElement documentElement = getClassElement(internalName, xmlClassElementTag);
            XElement metadataElement = element.getXmlElement();
            List<string> xmlClassElementItemTags = element.getRelevantClassTags();

            foreach (string xmlClassElementItemTag in xmlClassElementItemTags)
            {
                documentElement.Element(xmlClassElementItemTag).Value = metadataElement.Element(xmlClassElementItemTag).Value;
            }

            document.Save(fullPath);

            return true;
        }

        // TODO refactor

        public bool updateAbilitiesElement(string internalName, List<SoldierClassAbility> soldierAbilities)
        {
            foreach(SoldierClassAbility soldierAbility in soldierAbilities)
            {
                if (!soldierAbility.allowUpdate().valid)
                {
                    return false;
                }
            }

            XElement documentAbilitiesElement = getClassElement(internalName, Constants.XML_ABILITIES);
            List<XElement> documentAbilityElements = documentAbilitiesElement.Elements(Constants.XML_ABILITY).ToList();

            foreach(XElement documentAbilityElement in documentAbilityElements)
            {
                int? documentRank = Utils.parseStringToInt(documentAbilityElement.Element(Constants.XML_ABILITY_RANK).Value);
                int? documentSlot = Utils.parseStringToInt(documentAbilityElement.Element(Constants.XML_ABILITY_SLOT).Value);

                SoldierClassAbility soldierAbility = soldierAbilities.Where(x => (int)x.rank == documentRank && x.slot == documentSlot).SingleOrDefault();

                if(soldierAbility == null)
                {
                    documentAbilityElement.Element(Constants.XML_ABILITY_INTERNAL_NAME).Value = "";
                }
                else
                {
                    XElement abilityElement = soldierAbility.getXmlElement();
                    documentAbilityElement.Element(Constants.XML_ABILITY_INTERNAL_NAME).Value = abilityElement.Element(Constants.XML_ABILITY_INTERNAL_NAME).Value;
                }
            }

            document.Save(fullPath);

            return true;
        }

        public bool updateStatsElement(string internalName, List<SoldierClassStat> soldierStats)
        {
            foreach (SoldierClassStat soldierStat in soldierStats)
            {
                if (!soldierStat.allowUpdate().valid)
                {
                    return false;
                }
            }

            XElement documentStatsElement = getClassElement(internalName, Constants.XML_STATS);
            List<XElement> documentStatElements = documentStatsElement.Elements(Constants.XML_STAT).ToList();

            foreach (XElement documentStatElement in documentStatElements)
            {
                int? documentRank = Utils.parseStringToInt(documentStatElement.Element(Constants.XML_STAT_RANK).Value);
                int? documentType = Utils.parseStringToInt(documentStatElement.Element(Constants.XML_STAT_TYPE).Value);

                SoldierClassStat soldierStat = soldierStats.Where(x => (int)x.rank == documentRank && (int)x.stat == documentType).SingleOrDefault();

                if (soldierStat == null)
                {
                    documentStatElement.Element(Constants.XML_STAT_VALUE).Value = "";
                }
                else
                {
                    XElement statElement = soldierStat.getXmlElement();
                    documentStatElement.Element(Constants.XML_STAT_VALUE).Value = statElement.Element(Constants.XML_STAT_VALUE).Value;
                }
            }

            document.Save(fullPath);

            return true;
        }
    }
}
