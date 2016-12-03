using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XcomPerkManager.DataModels
{
    public class MetadataModel : IModel
    {
        public XElement model { get; set; }
        public string internalClassName { get; set; }

        public MetadataModel()
        {
            internalClassName = "";
            model = new XElement(Constants.XML_METADATA);

            model.Add(new XElement(Constants.XML_METADATA_INTERNAL_NAME));
            model.Element(Constants.XML_METADATA_INTERNAL_NAME).Value = "";

            model.Add(new XElement(Constants.XML_METADATA_DISPLAY_NAME));
            model.Element(Constants.XML_METADATA_DISPLAY_NAME).Value = "";

            model.Add(new XElement(Constants.XML_METADATA_DESCRIPTION));
            model.Element(Constants.XML_METADATA_DESCRIPTION).Value = "";

            model.Add(new XElement(Constants.XML_METADATA_ICON_STRING));
            model.Element(Constants.XML_METADATA_ICON_STRING).Value = "";
        }

        public MetadataModel(XElement model, string internalClassModel)
        {
            this.internalClassName = internalClassName;
            this.model = model;
        }

        public MetadataModel(MetadataModel original)
        {
            internalClassName = original.internalClassName;
            model = new XElement(Constants.XML_METADATA);

            model.Add(new XElement(Constants.XML_METADATA_INTERNAL_NAME));
            model.Element(Constants.XML_METADATA_INTERNAL_NAME).Value = original.model.Element(Constants.XML_METADATA_INTERNAL_NAME).Value;

            model.Add(new XElement(Constants.XML_METADATA_DISPLAY_NAME));
            model.Element(Constants.XML_METADATA_DISPLAY_NAME).Value = original.model.Element(Constants.XML_METADATA_DISPLAY_NAME).Value;

            model.Add(new XElement(Constants.XML_METADATA_DESCRIPTION));
            model.Element(Constants.XML_METADATA_DESCRIPTION).Value = original.model.Element(Constants.XML_METADATA_DESCRIPTION).Value;

            model.Add(new XElement(Constants.XML_METADATA_ICON_STRING));
            model.Element(Constants.XML_METADATA_ICON_STRING).Value = original.model.Element(Constants.XML_METADATA_ICON_STRING).Value;
        }
    }
}
