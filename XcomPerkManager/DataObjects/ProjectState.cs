using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XcomPerkManager.DataObjects
{
    public class ProjectState
    {
        private XComAbilityListReader reader;
        private SavedSoldiersManager manager;

        private SoldierClass openSoldierClass;
        private List<SoldierClass> soldierClasses;
        private List<Ability> abilities;

        public ProjectState()
        {
            reader = new XComAbilityListReader();
            abilities = reader.read();

            manager = new SavedSoldiersManager();
            loadSoldierClasses();

            setOpenSoldierClass(soldierClasses.FirstOrDefault());
        }
        
        public Ability getAbility(string internalName)
        {
            return abilities.Where(x => x.internalName.Equals(internalName)).SingleOrDefault();
        }

        public List<Ability> getAbilities()
        {
            return abilities;
        }

        public SoldierClass addClass()
        {
            SoldierClass newClass = manager.addNewSoldierClass();
            loadSoldierClasses();
            return newClass;
        }

        public SoldierClass saveClass(SoldierClass soldierClass)
        {
            return saveClass(getOpenSoldierClassInternalName(), soldierClass);
        }

        private SoldierClass saveClass(string originalInternalName, SoldierClass soldierClass)
        {
            manager.saveSoldierClass(originalInternalName, soldierClass);
            loadSoldierClasses();
            return soldierClass;
        }

        public void deleteClass()
        {
            deleteClass(openSoldierClass);
        }

        private void deleteClass(SoldierClass soldierClass)
        {
            deleteClass(soldierClass.getInternalName());
        }

        private void deleteClass(string soldierClassInternalName)
        {
            manager.deleteSoldierClass(soldierClassInternalName);
            loadSoldierClasses();

            if (!soldierClasses.Contains(openSoldierClass))
            {
                setOpenSoldierClass(soldierClasses.FirstOrDefault());
            }
        }

        public List<SoldierClass> getSoldierClasses()
        {
            return soldierClasses;
        }

        public SoldierClass getSoldierClass(string internalName)
        {
            return soldierClasses.Where(x => x.metadata.internalName.Equals(internalName)).FirstOrDefault();
        }

        public SoldierClass getOpenSoldierClass()
        {
            return openSoldierClass;
        }

        public string getOpenSoldierClassInternalName()
        {
            return openSoldierClass.getInternalName();
        }

        public SoldierClass setOpenSoldierClass(string soldierClassInternalName)
        {
            SoldierClass soldierClassToOpen = soldierClasses.Where(x => x.metadata.internalName.Equals(soldierClassInternalName)).SingleOrDefault();

            if(soldierClassToOpen == null)
            {
                throw new ArgumentException("Soldier class name is not in class list");
            }

            return setOpenSoldierClass(soldierClassToOpen);
        }

        private SoldierClass setOpenSoldierClass(SoldierClass soldierClass)
        {
            openSoldierClass = soldierClass;
            return openSoldierClass;
        }

        public SoldierClass renameClass(string newInternalName)
        {
            return renameClass(getOpenSoldierClassInternalName(), newInternalName);
        }

        private SoldierClass renameClass(string originalInternalName, string newInternalName)
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

        private void loadSoldierClasses()
        {
            soldierClasses = manager.loadAllSoldierClasses();
        }
    }
}
