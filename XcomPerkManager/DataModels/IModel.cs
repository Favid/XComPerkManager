using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XcomPerkManager.DataModels
{
    public interface IModel
    {
        XElement model { get; set; }
        string internalClassName { get; set; }
    }
}
