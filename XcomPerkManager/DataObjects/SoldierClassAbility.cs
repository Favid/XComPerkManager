using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XcomPerkManager
{
    public class SoldierClassAbility : Ability, ISoldierClassElement
    {
        public SoldierRank rank { get; set; }
        public int? slot { get; set; }

        public SoldierClassAbility() : base()
        {
            rank = SoldierRank.Squaddie;
            slot = 1;
        }

        public SoldierClassAbility(Ability ability) : base(ability)
        {
            rank = SoldierRank.Squaddie;
            slot = 1;
        }

        public Ability getAbility()
        {
            Ability ability = new Ability();
            ability.internalName = internalName;
            ability.displayName = displayName;
            ability.description = description;
            ability.requiredMod = requiredMod;

            return ability;
        }

        public XElement getXmlElement()
        {
            XElement abilityElement = new XElement(Constants.XML_ABILITY);

            abilityElement.Add(new XElement(Constants.XML_ABILITY_INTERNAL_NAME));
            abilityElement.Element(Constants.XML_ABILITY_INTERNAL_NAME).Value = this.internalName;

            abilityElement.Add(new XElement(Constants.XML_ABILITY_SLOT));
            abilityElement.Element(Constants.XML_ABILITY_SLOT).Value = this.slot.ToString();

            abilityElement.Add(new XElement(Constants.XML_ABILITY_RANK));
            abilityElement.Element(Constants.XML_ABILITY_RANK).Value = ((int)this.rank).ToString();

            return abilityElement;
        }

        public List<string> getRelevantClassTags()
        {
            List<string> tags = new List<string>();
            tags.Add(Constants.XML_ABILITY_INTERNAL_NAME);
            tags.Add(Constants.XML_ABILITY_SLOT);
            tags.Add(Constants.XML_ABILITY_RANK);

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
            SoldierClassAbility other = obj as SoldierClassAbility;
            if (other == null)
            {
                return false;
            }

            if (rank != other.rank)
            {
                return false;
            }

            if (slot != other.slot)
            {
                return false;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
