using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XcomPerkManager.DataModels
{
    public class SoldierClassModel : IModel
    {
        public XElement model { get; set; }
        public string internalClassName { get; set; }

        public SoldierClassModel()
        {
            internalClassName = "";
            model = new XElement(Constants.XML_CLASS);

            model.Add(new MetadataModel().model);
            model.Add(new AbilityModel().model);
            // TODO add equipment, experience, stats
        }

        public SoldierClassModel(XElement model, string internalClassModel)
        {
            this.internalClassName = internalClassName;
            this.model = model;
        }

        public SoldierClassModel(SoldierClassModel original)
        {
            internalClassName = original.internalClassName;
            

            // TODO
        }
    }
}
