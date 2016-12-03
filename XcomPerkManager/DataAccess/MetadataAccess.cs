using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XcomPerkManager.DataAccess;
using XcomPerkManager.DataModels;

namespace XcomPerkManager.DataAccess
{
    public class MetadataAccess : AbstractAccess<SoldierClassMetadata, MetadataModel>
    {
        public override MetadataModel create(string internalClassName) // TODO revisit - need to handle parents
        {
            MetadataModel model = new MetadataModel();
            model.internalClassName = internalClassName;
            model.model.Element(Constants.XML_METADATA_INTERNAL_NAME).Value = internalClassName;

            // save to document somehow

            return model;
        }

        public override MetadataModel get(string internalClassName)
        {
            XElement documentElement = document
                .Element(Constants.XML_CLASSES)
                .Elements(Constants.XML_CLASS)
                .Where(x => x.Element(Constants.XML_METADATA)
                .Element(Constants.XML_METADATA_INTERNAL_NAME)
                .Value == internalClassName)
                .Single()
                .Element(Constants.XML_METADATA);

            return new MetadataModel(documentElement, internalClassName);
        }

        public override List<MetadataModel> getAll()
        {
            List<XElement> documentElements = document
                .Element(Constants.XML_CLASSES)
                .Elements(Constants.XML_CLASS)
                .Elements(Constants.XML_METADATA)
                .ToList();

            List<MetadataModel> metadataModels = new List<MetadataModel>();

            foreach(XElement documentElement in documentElements)
            {
                MetadataModel metadataModel = new MetadataModel(documentElement, documentElement.Element(Constants.XML_METADATA_INTERNAL_NAME).Value);
                metadataModels.Add(metadataModel);
            }

            return metadataModels;
        }

        public override MetadataModel update(string internalClassName, SoldierClassMetadata dataObject)
        {
            if (!dataObject.allowUpdate().valid)
            {
                return null;
            }

            MetadataModel storedModel = get(internalClassName);

            storedModel.model.Element(Constants.XML_METADATA_INTERNAL_NAME).Value = dataObject.internalName;
            storedModel.model.Element(Constants.XML_METADATA_DISPLAY_NAME).Value = dataObject.displayName;
            storedModel.model.Element(Constants.XML_METADATA_DESCRIPTION).Value = dataObject.description;
            storedModel.model.Element(Constants.XML_METADATA_ICON_STRING).Value = dataObject.iconString;

            document.Save(fullPath);

            return get(dataObject.internalName);
        }

        public override MetadataModel delete(string internalClassName)
        {
            MetadataModel storedModel = get(internalClassName);

            foreach(XElement modelElement in storedModel.model.Elements())
            {
                modelElement.Remove();
            }

            document.Save(fullPath);

            return null;
        }
    }
}
