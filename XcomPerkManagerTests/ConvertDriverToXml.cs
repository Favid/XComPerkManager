using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XcomPerkManager.DataObjects;
using System.Xml.Linq;
using XcomPerkManager;

namespace XcomPerkManagerTests
{
    [TestClass]
    public class ConvertDriverToXml
    {
        [TestMethod]
        public void convertWeapon()
        {
            Weapon weapon = new Weapon();
            weapon.weaponName = "shotgun";
            weapon.weaponSlot = "primary";        // TODO verify if it should be primary or eInv_PrimaryWeapon

            XElement actual = XcomPerkManager.Conversion.Convert.toXmlWeapon(weapon);

            XElement expected = new XElement(Constants.XML_EQUIPMENT_WEAPON);
            expected.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_NAME, "shotgun"));
            expected.Add(new XElement(Constants.XML_EQUIPMENT_WEAPON_SLOT, "primary"));

            Assert.IsTrue(XNode.DeepEquals(expected, actual));
        }
    }
}
