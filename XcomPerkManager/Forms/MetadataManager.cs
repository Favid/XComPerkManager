using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XcomPerkManager.DataAccess;

namespace XcomPerkManager
{
    public partial class MetadataManager : Form
    {
        private string formerInternalName;

        public MetadataManager()
        {
            InitializeComponent();
        }

        public void loadSoldierClass(SoldierClass soldierClass)
        {
            tInternalName.Text = soldierClass.metadata.internalName;
            tDisplayName.Text = soldierClass.metadata.displayName;
            tDescription.Text = soldierClass.metadata.description;
            tIconString.Text = soldierClass.metadata.iconString;

            formerInternalName = soldierClass.metadata.internalName;
        }

        private void MetadataManager_Load(object sender, EventArgs e)
        {
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ClassOverview owner = Owner as ClassOverview;

            SoldierClassMetadata metadata = new SoldierClassMetadata();
            metadata.internalName = tInternalName.Text;
            metadata.displayName = tDisplayName.Text;
            metadata.description = tDescription.Text;
            metadata.iconString = tIconString.Text;

            ValidationResult allowUpdate = metadata.allowUpdate();
            if(!allowUpdate.valid)
            {
                MessageBox.Show(allowUpdate.message, "Cannot save", MessageBoxButtons.OK);
                return;
            }

            SavedSoldiersManager manager = new SavedSoldiersManager();
            manager.saveMetadata(formerInternalName, metadata);
            
            owner.updateSoldiers();
            owner.selectSoldier(metadata.internalName);
            
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
