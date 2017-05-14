using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XcomPerkManager
{
    public class SoldierClassExperience : ISoldierClassElement
    {
        public int? numberInForcedDeck { get; set; }
        public int? numberInDeck { get; set; }
        public int? killAssistsPerKill { get; set; }

        public SoldierClassExperience() : base()
        {
            numberInForcedDeck = 1;
            numberInDeck = 1;
            killAssistsPerKill = 1;
        }

        public SoldierClassExperience(SoldierClassExperience other) : base()
        {
            numberInForcedDeck = other.numberInForcedDeck;
            numberInDeck = other.numberInDeck;
            killAssistsPerKill = other.killAssistsPerKill;
        }

        public XElement getXmlElement()
        {
            XElement metadataElement = new XElement(Constants.XML_EXPERIENCE);

            metadataElement.Add(new XElement(Constants.XML_EXPERIENCE_NUM_IN_FORCED_DECK));
            metadataElement.Element(Constants.XML_EXPERIENCE_NUM_IN_FORCED_DECK).Value = this.numberInForcedDeck.ToString();

            metadataElement.Add(new XElement(Constants.XML_EXPERIENCE_NUM_IN_DECK));
            metadataElement.Element(Constants.XML_EXPERIENCE_NUM_IN_DECK).Value = this.numberInDeck.ToString();

            metadataElement.Add(new XElement(Constants.XML_EXPERIENCE_KILL_ASSISTS_PER_KILL));
            metadataElement.Element(Constants.XML_EXPERIENCE_KILL_ASSISTS_PER_KILL).Value = this.killAssistsPerKill.ToString();

            return metadataElement;
        }

        public List<string> getRelevantClassTags()
        {
            List<string> tags = new List<string>();
            tags.Add(Constants.XML_EXPERIENCE_NUM_IN_FORCED_DECK);
            tags.Add(Constants.XML_EXPERIENCE_NUM_IN_DECK);
            tags.Add(Constants.XML_EXPERIENCE_KILL_ASSISTS_PER_KILL);

            return tags;
        }

        public ValidationResult allowUpdate()
        {
            ValidationResult allowUpdate;
            allowUpdate.valid = true;
            allowUpdate.message = "";

            ValidationResult numberInForcedDeckValid = validateInteger(numberInForcedDeck, "Number in forced deck");
            allowUpdate.valid = allowUpdate.valid && numberInForcedDeckValid.valid;
            allowUpdate.message += numberInForcedDeckValid.message;

            ValidationResult numberInDeckValid = validateInteger(numberInDeck, "Number in deck");
            allowUpdate.valid = allowUpdate.valid && numberInDeckValid.valid;
            allowUpdate.message += numberInDeckValid.message;

            ValidationResult killAssistsPerKillValid = validateInteger(killAssistsPerKill, "Kill assists per kill");
            allowUpdate.valid = allowUpdate.valid && killAssistsPerKillValid.valid;
            allowUpdate.message += killAssistsPerKillValid.message;
            
            return allowUpdate;
        }

        private ValidationResult validateInteger(int? value, string name)
        {
            ValidationResult validationResult;
            validationResult.valid = true;
            validationResult.message = "";

            if (value == null)
            {
                validationResult.valid = false;
                validationResult.message += name + " cannot be null. " + Environment.NewLine;
            }

            if (value < 0)
            {
                validationResult.valid = false;
                validationResult.message += name + " cannot be a negative number. " + Environment.NewLine;
            }

            return validationResult;
        }

        public override bool Equals(object obj)
        {
            SoldierClassExperience other = obj as SoldierClassExperience;
            if (other == null)
            {
                return false;
            }

            if (numberInForcedDeck != other.numberInForcedDeck)
            {
                return false;
            }

            if (numberInDeck != other.numberInDeck)
            {
                return false;
            }

            if (killAssistsPerKill != other.killAssistsPerKill)
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
