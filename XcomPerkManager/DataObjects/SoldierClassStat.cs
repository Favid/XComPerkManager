using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XcomPerkManager
{
    public class SoldierClassStat : ISoldierClassElement
    {
        public Stat stat { get; set; }
        public int? value { get; set; }
        public SoldierRank rank { get; set; }

        public SoldierClassStat() : base()
        {
            stat = Stat.HP;
            value = 0;
            rank = SoldierRank.Squaddie;
        }

        public SoldierClassStat(SoldierClassStat other) : base()
        {
            stat = other.stat;
            value = other.value;
            rank = other.rank;
        }

        public XElement getXmlElement()
        {
            XElement abilityElement = new XElement(Constants.XML_STAT);

            abilityElement.Add(new XElement(Constants.XML_STAT_TYPE));
            abilityElement.Element(Constants.XML_STAT_TYPE).Value = ((int)this.stat).ToString();

            abilityElement.Add(new XElement(Constants.XML_STAT_VALUE));
            abilityElement.Element(Constants.XML_STAT_VALUE).Value = this.value.ToString();

            abilityElement.Add(new XElement(Constants.XML_STAT_RANK));
            abilityElement.Element(Constants.XML_STAT_RANK).Value = ((int)this.rank).ToString();

            return abilityElement;
        }

        public List<string> getRelevantClassTags()
        {
            List<string> tags = new List<string>();
            tags.Add(Constants.XML_STAT_TYPE);
            tags.Add(Constants.XML_STAT_VALUE);
            tags.Add(Constants.XML_STAT_RANK);

            return tags;
        }

        public ValidationResult allowUpdate()
        {
            ValidationResult allowUpdate;
            allowUpdate.valid = true;
            allowUpdate.message = "";

            return allowUpdate;
        }

        public override bool Equals(object obj)
        {
            SoldierClassStat other = obj as SoldierClassStat;
            if (other == null)
            {
                return false;
            }

            if (stat != other.stat)
            {
                return false;
            }

            if (value != other.value)
            {
                return false;
            }

            if (rank != other.rank)
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
