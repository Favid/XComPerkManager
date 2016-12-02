using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XcomPerkManager
{
    public partial class ExperienceManager : Form
    {
        private string formerInternalName;

        public ExperienceManager()
        {
            InitializeComponent();
        }

        private void ExperienceManager_Load(object sender, EventArgs e)
        {
            ClassOverview owner = Owner as ClassOverview;
            tNumberInForcedDeck.Text = owner.currentSoldier.experience.numberInForcedDeck.ToString();
            tNumberInDeck.Text = owner.currentSoldier.experience.numberInDeck.ToString();
            tKillAssistsPerKill.Text = owner.currentSoldier.experience.killAssistsPerKill.ToString();

            formerInternalName = owner.currentSoldier.metadata.internalName;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ClassOverview owner = Owner as ClassOverview;
            SavedSoldiersWriter writer = new SavedSoldiersWriter(owner.abilities);

            SoldierClassExperience experience = new SoldierClassExperience();
            experience.numberInForcedDeck = Utils.parseStringToInt(tNumberInForcedDeck.Text);
            experience.numberInDeck = Utils.parseStringToInt(tNumberInDeck.Text);
            experience.killAssistsPerKill = Utils.parseStringToInt(tKillAssistsPerKill.Text);
            
            writer.updateClassExperience(formerInternalName, experience);

            owner.updateSoldiers();
            owner.selectSoldier(formerInternalName);

            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
