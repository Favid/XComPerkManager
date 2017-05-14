using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XcomPerkManager.DataObjects
{
    public static class ProjectState
    {
        private static XComAbilityListReader reader;
        private static SavedSoldiersManager manager;

        private static SoldierClass openSoldierClass;
        private static List<SoldierClass> soldierClasses;
        private static List<Ability> abilities;

        static ProjectState()
        {
            reader = new XComAbilityListReader();
            abilities = reader.read();

            manager = new SavedSoldiersManager();
            loadSoldierClasses();

            setOpenSoldierClass(soldierClasses.FirstOrDefault());
        }

        public static List<Ability> reloadAbilities()
        {
            reader = new XComAbilityListReader();
            abilities = reader.read();
            return abilities;
        }

        public static Ability getAbility(string internalName)
        {
            return abilities.Where(x => x.internalName.Equals(internalName)).SingleOrDefault();
        }

        public static List<Ability> getAbilities()
        {
            return abilities;
        }

        public static SoldierClass addClass()
        {
            SoldierClass newClass = manager.addNewSoldierClass();
            loadSoldierClasses();
            return newClass;
        }

        public static SoldierClass saveClass(SoldierClass soldierClass)
        {
            return saveClass(getOpenSoldierClassInternalName(), soldierClass);
        }

        private static SoldierClass saveClass(string originalInternalName, SoldierClass soldierClass)
        {
            manager.saveSoldierClass(originalInternalName, soldierClass);
            loadSoldierClasses();
            return soldierClass;
        }

        public static void deleteClass()
        {
            deleteClass(openSoldierClass);
        }

        private static void deleteClass(SoldierClass soldierClass)
        {
            deleteClass(soldierClass.getInternalName());
        }

        private static void deleteClass(string soldierClassInternalName)
        {
            manager.deleteSoldierClass(soldierClassInternalName);
            loadSoldierClasses();

            if (!soldierClasses.Contains(openSoldierClass))
            {
                setOpenSoldierClass(soldierClasses.FirstOrDefault());
            }
        }

        public static List<SoldierClass> getSoldierClasses()
        {
            return soldierClasses;
        }

        public static SoldierClass getSoldierClass(string internalName)
        {
            return soldierClasses.Where(x => x.metadata.internalName.Equals(internalName)).FirstOrDefault();
        }

        public static SoldierClass getOpenSoldierClass()
        {
            return openSoldierClass;
        }

        public static string getOpenSoldierClassInternalName()
        {
            return openSoldierClass.getInternalName();
        }

        public static SoldierClass setOpenSoldierClass(string soldierClassInternalName)
        {
            SoldierClass soldierClassToOpen = soldierClasses.Where(x => x.metadata.internalName.Equals(soldierClassInternalName)).SingleOrDefault();

            if(soldierClassToOpen == null)
            {
                throw new ArgumentException("Soldier class name is not in class list");
            }

            return setOpenSoldierClass(soldierClassToOpen);
        }

        private static SoldierClass setOpenSoldierClass(SoldierClass soldierClass)
        {
            openSoldierClass = soldierClass;
            return openSoldierClass;
        }

        public static SoldierClass renameClass(string newInternalName)
        {
            return renameClass(getOpenSoldierClassInternalName(), newInternalName);
        }

        private static SoldierClass renameClass(string originalInternalName, string newInternalName)
        {
            // TODO validation
            manager.saveInternalName(originalInternalName, newInternalName);
            loadSoldierClasses();

            if(!soldierClasses.Contains(openSoldierClass))
            {
                setOpenSoldierClass(newInternalName);
            }

            return getSoldierClass(newInternalName);
        }

        private static void loadSoldierClasses()
        {
            soldierClasses = manager.loadAllSoldierClasses();
        }
    }
}
