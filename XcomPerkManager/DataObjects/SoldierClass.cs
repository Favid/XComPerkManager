﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public SoldierClass(SoldierClass other)
        {
            metadata = new SoldierClassMetadata(other.metadata);
            experience = new SoldierClassExperience(other.experience);
            equipment = new SoldierClassEquipment(other.equipment);

            soldierAbilities = new List<SoldierClassAbility>();
            foreach (SoldierClassAbility soldierAbility in other.soldierAbilities)
            {
                soldierAbilities.Add(new SoldierClassAbility(soldierAbility));
            }

            stats = new List<SoldierClassStat>();
            foreach (SoldierClassStat stat in other.stats)
            {
                stats.Add(new SoldierClassStat(stat));
            }
        }

        public string getInternalName()
        {
            return metadata.internalName;
        }

        public XElement createNewSoldierClass()
        {
            throw new NotImplementedException();
        }

        public SoldierClassStat getStat(SoldierRank rank, Stat stat)
        {
            return stats.Where(x => x.rank == rank && x.stat == stat).SingleOrDefault();
        }

        public int? getStatValue(SoldierRank rank, Stat stat)
        {
            SoldierClassStat classStat = stats.Where(x => x.rank == rank && x.stat == stat).SingleOrDefault();
            if(classStat == null)
            {
                return null;
            }

            return classStat.value;
        }

        public string getStatValueText(SoldierRank rank, Stat stat)
        {
            int? statValue = getStatValue(rank, stat);
            if(statValue == null)
            {
                return "";
            }

            return statValue.ToString();
        }

        public SoldierClassAbility getSoldierAbility(SoldierRank rank, int slot)
        {
            SoldierClassAbility soldierAbility = soldierAbilities.Where(x => x.rank == rank && x.slot == slot).FirstOrDefault();

            return soldierAbility;
        }
    }
}
