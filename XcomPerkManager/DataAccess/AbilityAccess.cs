using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XcomPerkManager.DataModels;

namespace XcomPerkManager.DataAccess
{
    public class AbilityAccess : AbstractAccess<SoldierClassAbility, AbilityModel>
    {
        public override AbilityModel create(string internalClassName) // TODO revisit - need to handle parents
        {
            AbilityModel model = new AbilityModel();
            model.internalClassName = internalClassName;

            // save to document somehow

            return model;
        }

        public override AbilityModel get(string internalClassName)
        {
            XElement documentElement = document
                .Element(Constants.XML_CLASSES)
                .Elements(Constants.XML_CLASS)
                .Where(x => x.Element(Constants.XML_METADATA)
                .Element(Constants.XML_METADATA_INTERNAL_NAME)
                .Value == internalClassName)
                .Single()
                .Element(Constants.XML_METADATA);

            return new AbilityModel(documentElement, internalClassName);
        }

        public override List<AbilityModel> getAll()
        {
            List<XElement> documentElements = document
                .Element(Constants.XML_CLASSES)
                .Elements(Constants.XML_CLASS)
                .Elements(Constants.XML_METADATA)
                .ToList();

            List<AbilityModel> metadataModels = new List<AbilityModel>();

            foreach (XElement documentElement in documentElements)
            {
                AbilityModel metadataModel = new AbilityModel(documentElement, documentElement.Element(Constants.XML_METADATA_INTERNAL_NAME).Value);
                metadataModels.Add(metadataModel);
            }

            return metadataModels;
        }

        public override AbilityModel update(string internalClassName, SoldierClassAbility dataObject)
        {
            if (!dataObject.allowUpdate().valid)
            {
                return null;
            }

            AbilityModel storedModel = get(internalClassName);

            storedModel.model.Element(Constants.XML_METADATA_INTERNAL_NAME).Value = dataObject.internalName;
            storedModel.model.Element(Constants.XML_METADATA_DISPLAY_NAME).Value = dataObject.displayName;
            storedModel.model.Element(Constants.XML_METADATA_DESCRIPTION).Value = dataObject.description;

            document.Save(fullPath);

            return get(dataObject.internalName);
        }

        public override AbilityModel delete(string internalClassName)
        {
            AbilityModel storedModel = get(internalClassName);

            foreach (XElement modelElement in storedModel.model.Elements())
            {
                modelElement.Remove();
            }

            document.Save(fullPath);

            return null;
        }
    }
}
