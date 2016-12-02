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
    }
}
