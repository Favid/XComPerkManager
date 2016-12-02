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
    public partial class MetadataManager : Form
    {
        private string formerInternalName;

        public MetadataManager()
        {
            InitializeComponent();
        }

        private void MetadataManager_Load(object sender, EventArgs e)
        {
            ClassOverview owner = Owner as ClassOverview;
            tInternalName.Text = owner.currentSoldier.metadata.internalName;
            tDisplayName.Text = owner.currentSoldier.metadata.displayName;
            tDescription.Text = owner.currentSoldier.metadata.description;
            tIconString.Text = owner.currentSoldier.metadata.iconString;

            formerInternalName = owner.currentSoldier.metadata.internalName;
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
            manager.updateClassElement(formerInternalName, metadata, Constants.XML_METADATA);

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
