using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XcomPerkManager
{
    public class SoldierClass
    {
        public SoldierClassMetadata metadata { get; set; }
        public SoldierClassExperience experience { get; set; }
        public SoldierClassEquipment equipment { get; set; }
        public List<SoldierClassAbility> soldierAbilities { get; set; }
        public List<SoldierClassStat> stats { get; set; }

        public SoldierClass()
        {
            metadata = new SoldierClassMetadata();
            experience = new SoldierClassExperience();
            equipment = new SoldierClassEquipment();
            soldierAbilities = new List<SoldierClassAbility>();
            stats = new List<SoldierClassStat>();
        }
    }
}
