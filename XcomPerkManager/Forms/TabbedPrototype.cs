using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XcomPerkManager.DataObjects;

namespace XcomPerkManager.Forms
{
    public partial class TabbedPrototype : Form
    {
        public ProjectState state;

        public TabbedPrototype()
        {
            InitializeComponent();
        }

        private void TabbedPrototype_Load(object sender, EventArgs e)
        {
            state = new ProjectState();
            open(state.getOpenSoldierClass());
        }

        private void setupMenuItemOpen()
        {
            menuItemOpen.DropDownItems.Clear();

            List<SoldierClass> soldierClasses = state.getSoldierClasses();
            foreach(SoldierClass soldierClass in soldierClasses)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(soldierClass.metadata.internalName);
                item.Tag = soldierClass;
                item.Click += new System.EventHandler(this.menuItemOpenSoldierClass_Click);
                menuItemOpen.DropDownItems.Add(item);
            }
        }

        private void menuItemOpenSoldierClass_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            SoldierClass soldierClass = (SoldierClass)item.Tag;
            open(soldierClass);
        }

        private void open(SoldierClass soldierClass)
        {
            SoldierClass openSoldierClass = state.setOpenSoldierClass(soldierClass.getInternalName());
            setupMenuItemOpen();

            tDisplayName.Text = soldierClass.metadata.displayName;
            tDescription.Text = soldierClass.metadata.description;
            tIconString.Text = soldierClass.metadata.iconString;

            tNumInForcedDeck.Text = soldierClass.experience.numberInForcedDeck.ToString();
            tNumInDeck.Text = soldierClass.experience.numberInDeck.ToString();
            tKillAssistsPerKill.Text = soldierClass.experience.killAssistsPerKill.ToString();

            tSquaddieLoadout.Text = soldierClass.equipment.squaddieLoadout;
            tAllowedArmor.Text = soldierClass.equipment.allowedArmors;
        }

        private SoldierClass buildSoldierClass()
        {
            SoldierClass soldierClass = new SoldierClass();

            soldierClass.metadata.internalName = state.getOpenSoldierClass().metadata.internalName;
            soldierClass.metadata.displayName = tDisplayName.Text;
            soldierClass.metadata.description = tDescription.Text;
            soldierClass.metadata.iconString = tIconString.Text;

            soldierClass.experience.numberInForcedDeck = int.Parse(tNumInForcedDeck.Text);
            soldierClass.experience.numberInDeck = int.Parse(tNumInDeck.Text);
            soldierClass.experience.killAssistsPerKill = int.Parse(tKillAssistsPerKill.Text);

            soldierClass.equipment.squaddieLoadout = tSquaddieLoadout.Text;
            soldierClass.equipment.allowedArmors = tAllowedArmor.Text;

            return soldierClass;
        }
        
        private void selectClassToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO make sure rest of data can be saved first

            SoldierClass soldierClass = state.saveClass(buildSoldierClass());
            open(soldierClass);
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rename rename = new Rename(state.getOpenSoldierClass().metadata.internalName);
            rename.FormClosing += renameClosingListener;
            rename.ShowDialog(this);
        }
        
        private void renameClosingListener(object sender, FormClosingEventArgs e)
        {
            Rename renameForm = sender as Rename;
            if (renameForm != null)
            {
                if (!renameForm.getNewName().Equals(state.getOpenSoldierClassInternalName()))
                {
                    state.renameClass(renameForm.getNewName());
                    setupMenuItemOpen();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoldierClass newClass = state.addClass();
            open(newClass);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            state.deleteClass();
            open(state.getOpenSoldierClass());
        }
    }
}
