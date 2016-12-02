using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XcomPerkManager
{
    public interface ISoldierClassElement
    {
        XElement getXmlElement();
        ValidationResult allowUpdate();
        List<string> getRelevantClassTags();
    }
}
