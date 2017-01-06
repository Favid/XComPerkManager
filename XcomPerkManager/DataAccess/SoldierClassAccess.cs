using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XcomPerkManager.DataAccess;
using XcomPerkManager.DataModels;

namespace XcomPerkManager.DataAccess
{
    public class SoldierClassAccess : AbstractAccess<SoldierClassMetadata, SoldierClassModel>
    {
        public override SoldierClassModel create(string internalClassName) // TODO revisit - need to handle parents
        {
            SoldierClassModel model = new SoldierClassModel();
            model.internalClassName = internalClassName;

            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(currentDir);
            DirectoryInfo root = directory.Parent.Parent;
            string newClassPath = Path.Combine(root.FullName, "NewClass.xml");

            XDocument newClassDocument = XDocument.Load(newClassPath);

            model.model = newClassDocument
                .Element(Constants.XML_CLASSES)
                .Element(Constants.XML_CLASS);

            model.internalClassName = getNewName();
            model.model
                .Element(Constants.XML_METADATA)
                .Element(Constants.XML_METADATA_INTERNAL_NAME)
                .Value = model.internalClassName;

            document
                .Element(Constants.XML_CLASSES)
                .Add(model.model);

            document.Save(fullPath);

            return model;
        }

        private string getNewName()
        {
            string name = "New";

            if(validName(name))
            {
                return name;
            }

            for (int i = 1; i < 999; i++)
            {
                string workingName = name += i.ToString();

                if(validName(workingName))
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

            foreach(XElement classElement in classElements)
            {
                string internalClassName = classElement
                    .Element(Constants.XML_METADATA)
                    .Element(Constants.XML_METADATA_INTERNAL_NAME)
                    .Value;

                if(name == internalClassName)
                {
                    return false;
                }
            }

            return true;
        }

        public override SoldierClassModel get(string internalClassName)
        {
            XElement documentElement = document
                .Element(Constants.XML_CLASSES)
                .Elements(Constants.XML_CLASS)
                .Where(x => x.Element(Constants.XML_METADATA)
                .Element(Constants.XML_METADATA_INTERNAL_NAME)
                .Value == internalClassName)
                .Single();

            return new SoldierClassModel(documentElement, internalClassName);
        }

        public override List<SoldierClassModel> getAll()
        {
            List<XElement> documentElements = document
                .Element(Constants.XML_CLASSES)
                .Elements(Constants.XML_CLASS)
                .ToList();

            List<SoldierClassModel> classModels = new List<SoldierClassModel>();

            foreach (XElement documentElement in documentElements)
            {
                SoldierClassModel classModel = new SoldierClassModel(documentElement, documentElement.Element(Constants.XML_METADATA).Element(Constants.XML_METADATA_INTERNAL_NAME).Value);
                classModels.Add(classModel);
            }

            return classModels;
        }

        public override SoldierClassModel update(string internalClassName, SoldierClassMetadata dataObject)
        {
            // TODO

            //if (!dataObject.allowUpdate().valid)
            //{
            //    return null;
            //}

            //SoldierClassModel storedModel = get(internalClassName);

            //storedModel.model.Element(Constants.XML_METADATA_INTERNAL_NAME).Value = dataObject.internalName;
            //storedModel.model.Element(Constants.XML_METADATA_DISPLAY_NAME).Value = dataObject.displayName;
            //storedModel.model.Element(Constants.XML_METADATA_DESCRIPTION).Value = dataObject.description;
            //storedModel.model.Element(Constants.XML_METADATA_ICON_STRING).Value = dataObject.iconString;

            //document.Save(fullPath);

            return get(dataObject.internalName);
        }

        public override SoldierClassModel delete(string internalClassName)
        {
            SoldierClassModel storedModel = get(internalClassName);
            storedModel.model.Remove();

            document.Save(fullPath);

            return null;
        }
    }
}
