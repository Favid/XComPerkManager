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

        private String openSoldierClassOriginalName;

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

        public SoldierClass addClass()
        {
            SoldierClass newClass = manager.addNewSoldierClass();
            loadSoldierClasses();
            return newClass;
        }

        public SoldierClass saveOpenClass()
        {
            return saveClass(openSoldierClassOriginalName, openSoldierClass);
        }

        public SoldierClass saveClass(SoldierClass soldierClass)
        {
            manager.saveSoldierClass(openSoldierClassOriginalName, soldierClass);
            loadSoldierClasses();
            return soldierClass;
        }

        public SoldierClass saveClass(string originalInternalName, SoldierClass soldierClass)
        {
            manager.saveSoldierClass(originalInternalName, soldierClass);
            loadSoldierClasses();
            return soldierClass;
        }

        public void deleteClass(string originalInternalName, SoldierClass soldierClass)
        {
            manager.deleteSoldierClass(originalInternalName);
        }

        public List<SoldierClass> getSoldierClasses()
        {
            return soldierClasses;
        }

        public SoldierClass getSoldierClass(string internalName)
        {
            return soldierClasses.Where(x => x.metadata.internalName.Equals(internalName)).FirstOrDefault();
        }

        public SoldierClass getOpenSolderClass()
        {
            return openSoldierClass;
        }

        public SoldierClass setOpenSoldierClass(SoldierClass soldierClass)
        {
            openSoldierClass = soldierClass;
            openSoldierClassOriginalName = openSoldierClass.metadata.internalName;
            return openSoldierClass;
        }

        public SoldierClass renameClass(string originalInternalName, string newInternalName)
        {
            // TODO validation
            manager.saveInternalName(originalInternalName, newInternalName);
            loadSoldierClasses();
            return getSoldierClass(newInternalName);
        }

        private void loadSoldierClasses()
        {
            soldierClasses = manager.loadAllSoldierClasses();
        }
    }
}
