using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XcomPerkManager.DataModels
{
    public class AbilityModel : IModel
    {
        public XElement model { get; set; }
        public string internalClassName { get; set; }

        public AbilityModel()
        {
            internalClassName = "";
            model = new XElement(Constants.XML_ABILITY);

            model.Add(new XElement(Constants.XML_ABILITY_INTERNAL_NAME));
            model.Element(Constants.XML_ABILITY_INTERNAL_NAME).Value = "";

            model.Add(new XElement(Constants.XML_ABILITY_SLOT));
            model.Element(Constants.XML_ABILITY_SLOT).Value = "";

            model.Add(new XElement(Constants.XML_ABILITY_RANK));
            model.Element(Constants.XML_ABILITY_RANK).Value = "";
        }

        public AbilityModel(XElement model, string internalClassModel)
        {
            this.internalClassName = internalClassName;
            this.model = model;
        }

        public AbilityModel(AbilityModel original)
        {
            internalClassName = original.internalClassName;
            model = new XElement(Constants.XML_ABILITY);

            model.Add(new XElement(Constants.XML_ABILITY_INTERNAL_NAME));
            model.Element(Constants.XML_ABILITY_INTERNAL_NAME).Value = original.model.Element(Constants.XML_ABILITY_INTERNAL_NAME).Value;

            model.Add(new XElement(Constants.XML_ABILITY_SLOT));
            model.Element(Constants.XML_ABILITY_SLOT).Value = original.model.Element(Constants.XML_ABILITY_SLOT).Value;

            model.Add(new XElement(Constants.XML_ABILITY_RANK));
            model.Element(Constants.XML_ABILITY_RANK).Value = original.model.Element(Constants.XML_ABILITY_RANK).Value;
        }
    }
}
