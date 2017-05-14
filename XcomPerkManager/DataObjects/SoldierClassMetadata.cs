using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XcomPerkManager
{
    public class SoldierClassMetadata : ISoldierClassElement
    {
        public string internalName { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public string iconString { get; set; }

        public SoldierClassMetadata() : base()
        {
            internalName = "";
            displayName = "";
            description = "";
            iconString = "";
        }

        public SoldierClassMetadata(SoldierClassMetadata other) : base()
        {
            internalName = other.internalName;
            displayName = other.displayName;
            description = other.description;
            iconString = other.iconString;
        }

        public XElement getXmlElement()
        {
            XElement metadataElement = new XElement(Constants.XML_METADATA);
            
            metadataElement.Add(new XElement(Constants.XML_METADATA_INTERNAL_NAME));
            metadataElement.Element(Constants.XML_METADATA_INTERNAL_NAME).Value = this.internalName;

            metadataElement.Add(new XElement(Constants.XML_METADATA_DISPLAY_NAME));
            metadataElement.Element(Constants.XML_METADATA_DISPLAY_NAME).Value = this.displayName;

            metadataElement.Add(new XElement(Constants.XML_METADATA_DESCRIPTION));
            metadataElement.Element(Constants.XML_METADATA_DESCRIPTION).Value = this.description;

            metadataElement.Add(new XElement(Constants.XML_METADATA_ICON_STRING));
            metadataElement.Element(Constants.XML_METADATA_ICON_STRING).Value = this.iconString;

            return metadataElement;
        }

        public List<string> getRelevantClassTags()
        {
            List<string> tags = new List<string>();
            tags.Add(Constants.XML_METADATA_INTERNAL_NAME);
            tags.Add(Constants.XML_METADATA_DISPLAY_NAME);
            tags.Add(Constants.XML_METADATA_DESCRIPTION);
            tags.Add(Constants.XML_METADATA_ICON_STRING);

            return tags;
        }

        public ValidationResult allowUpdate()
        {
            ValidationResult allowUpdate;
            allowUpdate.valid = true;
            allowUpdate.message = "";

            if (string.IsNullOrEmpty(internalName))
            {
                allowUpdate.valid = false;
                allowUpdate.message += "Internal name cannot be empty. " + Environment.NewLine;
            }

            // TODO check for unique name

            if (string.IsNullOrEmpty(displayName))
            {
                allowUpdate.valid = false;
                allowUpdate.message += "Display name cannot be empty. " + Environment.NewLine;
            }

            return allowUpdate;
        }

        public override string ToString()
        {
            return internalName;
        }

        public override bool Equals(object obj)
        {
            SoldierClassMetadata other = obj as SoldierClassMetadata;
            if (other == null)
            {
                return false;
            }

            if (!String.Equals(internalName, other.internalName))
            {
                return false;
            }

            if (!String.Equals(displayName, other.displayName))
            {
                return false;
            }

            if (!String.Equals(description, other.description))
            {
                return false;
            }

            if (!String.Equals(iconString, other.iconString))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
