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

            BindingList<Weapon> weapons = new BindingList<Weapon>(soldierClass.equipment.weapons);
            lWeapons.DataSource = weapons;

            openSoldierStats(soldierClass);
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
            soldierClass.equipment.weapons = (lWeapons.DataSource as BindingList<Weapon>).ToList();

            soldierClass.stats = buildSoldierClassStats();

            return soldierClass;
        }

        private List<SoldierClassStat> buildSoldierClassStats()
        {
            List<SoldierClassStat> soldierStats = new List<SoldierClassStat>();

            soldierStats.Add(buildSoldierStatFromControl(tSquaddieHp, SoldierRank.Squaddie, Stat.HP));
            soldierStats.Add(buildSoldierStatFromControl(tCorporalHp, SoldierRank.Corporal, Stat.HP));
            soldierStats.Add(buildSoldierStatFromControl(tSergeantHp, SoldierRank.Sergeant, Stat.HP));
            soldierStats.Add(buildSoldierStatFromControl(tLieutenantHp, SoldierRank.Lieutenant, Stat.HP));
            soldierStats.Add(buildSoldierStatFromControl(tCaptainHp, SoldierRank.Captain, Stat.HP));
            soldierStats.Add(buildSoldierStatFromControl(tMajorHp, SoldierRank.Major, Stat.HP));
            soldierStats.Add(buildSoldierStatFromControl(tColonelHp, SoldierRank.Colonel, Stat.HP));
            soldierStats.Add(buildSoldierStatFromControl(tBrigadierHp, SoldierRank.Brigadier, Stat.HP));

            soldierStats.Add(buildSoldierStatFromControl(tSquaddieAim, SoldierRank.Squaddie, Stat.Aim));
            soldierStats.Add(buildSoldierStatFromControl(tCorporalAim, SoldierRank.Corporal, Stat.Aim));
            soldierStats.Add(buildSoldierStatFromControl(tSergeantAim, SoldierRank.Sergeant, Stat.Aim));
            soldierStats.Add(buildSoldierStatFromControl(tLieutenantAim, SoldierRank.Lieutenant, Stat.Aim));
            soldierStats.Add(buildSoldierStatFromControl(tCaptainAim, SoldierRank.Captain, Stat.Aim));
            soldierStats.Add(buildSoldierStatFromControl(tMajorAim, SoldierRank.Major, Stat.Aim));
            soldierStats.Add(buildSoldierStatFromControl(tColonelAim, SoldierRank.Colonel, Stat.Aim));
            soldierStats.Add(buildSoldierStatFromControl(tBrigadierAim, SoldierRank.Brigadier, Stat.Aim));

            soldierStats.Add(buildSoldierStatFromControl(tSquaddieStrength, SoldierRank.Squaddie, Stat.Strength));
            soldierStats.Add(buildSoldierStatFromControl(tCorporalStrength, SoldierRank.Corporal, Stat.Strength));
            soldierStats.Add(buildSoldierStatFromControl(tSergeantStrength, SoldierRank.Sergeant, Stat.Strength));
            soldierStats.Add(buildSoldierStatFromControl(tLieutenantStrength, SoldierRank.Lieutenant, Stat.Strength));
            soldierStats.Add(buildSoldierStatFromControl(tCaptainStrength, SoldierRank.Captain, Stat.Strength));
            soldierStats.Add(buildSoldierStatFromControl(tMajorStrength, SoldierRank.Major, Stat.Strength));
            soldierStats.Add(buildSoldierStatFromControl(tColonelStrength, SoldierRank.Colonel, Stat.Strength));
            soldierStats.Add(buildSoldierStatFromControl(tBrigadierStrength, SoldierRank.Brigadier, Stat.Strength));

            soldierStats.Add(buildSoldierStatFromControl(tSquaddieHacking, SoldierRank.Squaddie, Stat.Hacking));
            soldierStats.Add(buildSoldierStatFromControl(tCorporalHacking, SoldierRank.Corporal, Stat.Hacking));
            soldierStats.Add(buildSoldierStatFromControl(tSergeantHacking, SoldierRank.Sergeant, Stat.Hacking));
            soldierStats.Add(buildSoldierStatFromControl(tLieutenantHacking, SoldierRank.Lieutenant, Stat.Hacking));
            soldierStats.Add(buildSoldierStatFromControl(tCaptainHacking, SoldierRank.Captain, Stat.Hacking));
            soldierStats.Add(buildSoldierStatFromControl(tMajorHacking, SoldierRank.Major, Stat.Hacking));
            soldierStats.Add(buildSoldierStatFromControl(tColonelHacking, SoldierRank.Colonel, Stat.Hacking));
            soldierStats.Add(buildSoldierStatFromControl(tBrigadierHacking, SoldierRank.Brigadier, Stat.Hacking));

            soldierStats.Add(buildSoldierStatFromControl(tSquaddiePsi, SoldierRank.Squaddie, Stat.Psi));
            soldierStats.Add(buildSoldierStatFromControl(tCorporalPsi, SoldierRank.Corporal, Stat.Psi));
            soldierStats.Add(buildSoldierStatFromControl(tSergeantPsi, SoldierRank.Sergeant, Stat.Psi));
            soldierStats.Add(buildSoldierStatFromControl(tLieutenantPsi, SoldierRank.Lieutenant, Stat.Psi));
            soldierStats.Add(buildSoldierStatFromControl(tCaptainPsi, SoldierRank.Captain, Stat.Psi));
            soldierStats.Add(buildSoldierStatFromControl(tMajorPsi, SoldierRank.Major, Stat.Psi));
            soldierStats.Add(buildSoldierStatFromControl(tColonelPsi, SoldierRank.Colonel, Stat.Psi));
            soldierStats.Add(buildSoldierStatFromControl(tBrigadierPsi, SoldierRank.Brigadier, Stat.Psi));

            soldierStats.Add(buildSoldierStatFromControl(tSquaddieMobility, SoldierRank.Squaddie, Stat.Mobility));
            soldierStats.Add(buildSoldierStatFromControl(tCorporalMobility, SoldierRank.Corporal, Stat.Mobility));
            soldierStats.Add(buildSoldierStatFromControl(tSergeantMobility, SoldierRank.Sergeant, Stat.Mobility));
            soldierStats.Add(buildSoldierStatFromControl(tLieutenantMobility, SoldierRank.Lieutenant, Stat.Mobility));
            soldierStats.Add(buildSoldierStatFromControl(tCaptainMobility, SoldierRank.Captain, Stat.Mobility));
            soldierStats.Add(buildSoldierStatFromControl(tMajorMobility, SoldierRank.Major, Stat.Mobility));
            soldierStats.Add(buildSoldierStatFromControl(tColonelMobility, SoldierRank.Colonel, Stat.Mobility));
            soldierStats.Add(buildSoldierStatFromControl(tBrigadierMobility, SoldierRank.Brigadier, Stat.Mobility));

            soldierStats.Add(buildSoldierStatFromControl(tSquaddieWill, SoldierRank.Squaddie, Stat.Will));
            soldierStats.Add(buildSoldierStatFromControl(tCorporalWill, SoldierRank.Corporal, Stat.Will));
            soldierStats.Add(buildSoldierStatFromControl(tSergeantWill, SoldierRank.Sergeant, Stat.Will));
            soldierStats.Add(buildSoldierStatFromControl(tLieutenantWill, SoldierRank.Lieutenant, Stat.Will));
            soldierStats.Add(buildSoldierStatFromControl(tCaptainWill, SoldierRank.Captain, Stat.Will));
            soldierStats.Add(buildSoldierStatFromControl(tMajorWill, SoldierRank.Major, Stat.Will));
            soldierStats.Add(buildSoldierStatFromControl(tColonelWill, SoldierRank.Colonel, Stat.Will));
            soldierStats.Add(buildSoldierStatFromControl(tBrigadierWill, SoldierRank.Brigadier, Stat.Will));

            soldierStats.Add(buildSoldierStatFromControl(tSquaddieDodge, SoldierRank.Squaddie, Stat.Dodge));
            soldierStats.Add(buildSoldierStatFromControl(tCorporalDodge, SoldierRank.Corporal, Stat.Dodge));
            soldierStats.Add(buildSoldierStatFromControl(tSergeantDodge, SoldierRank.Sergeant, Stat.Dodge));
            soldierStats.Add(buildSoldierStatFromControl(tLieutenantDodge, SoldierRank.Lieutenant, Stat.Dodge));
            soldierStats.Add(buildSoldierStatFromControl(tCaptainDodge, SoldierRank.Captain, Stat.Dodge));
            soldierStats.Add(buildSoldierStatFromControl(tMajorDodge, SoldierRank.Major, Stat.Dodge));
            soldierStats.Add(buildSoldierStatFromControl(tColonelDodge, SoldierRank.Colonel, Stat.Dodge));
            soldierStats.Add(buildSoldierStatFromControl(tBrigadierDodge, SoldierRank.Brigadier, Stat.Dodge));

            return soldierStats;
        }

        private SoldierClassStat buildSoldierStatFromControl(TextBox control, SoldierRank rank, Stat stat)
        {
            SoldierClassStat soldierStat = new SoldierClassStat();

            soldierStat.rank = rank;
            soldierStat.stat = stat;
            soldierStat.value = Utils.parseStringToInt(control.Text);

            return soldierStat;
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

        private void bEditWeapon_Click(object sender, EventArgs e)
        {
            WeaponEditor weaponEditor = new WeaponEditor(lWeapons.SelectedItem as Weapon, EditorState.EDIT);
            weaponEditor.FormClosing += weaponEditorClosingListener;
            weaponEditor.ShowDialog(this);
        }

        private void bAddWeapon_Click(object sender, EventArgs e)
        {
            WeaponEditor weaponEditor = new WeaponEditor(null, EditorState.ADD);
            weaponEditor.FormClosing += weaponEditorClosingListener;
            weaponEditor.ShowDialog(this);
        }

        private void weaponEditorClosingListener(object sender, FormClosingEventArgs e)
        {
            WeaponEditor weaponEditor = sender as WeaponEditor;
            if (weaponEditor != null)
            {
                BindingList<Weapon> weapons = lWeapons.DataSource as BindingList<Weapon>;
                Weapon oldWeapon = weaponEditor.oldWeapon;
                Weapon newWeapon = weaponEditor.newWeapon;

                if(weaponEditor.editorState == EditorState.CANCEL)
                {
                    return;
                }
                else if (weaponEditor.editorState == EditorState.ADD)
                {
                    weapons.Add(newWeapon);
                    lWeapons.DataSource = weapons;
                }
                else if (weaponEditor.editorState == EditorState.EDIT)
                {
                    int index = weapons.IndexOf(oldWeapon);

                    if(index == -1)
                    {
                        weapons.Add(newWeapon);
                    }
                    else
                    {
                        weapons[index] = newWeapon;
                    }
                    
                    lWeapons.DataSource = weapons;
                }
            }
        }

        private void bDeleteWeapon_Click(object sender, EventArgs e)
        {
            BindingList<Weapon> weapons = lWeapons.DataSource as BindingList<Weapon>;
            weapons.Remove(lWeapons.SelectedItem as Weapon);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openSoldierStats(SoldierClass soldierClass)
        {
            tSquaddieHp.Text = soldierClass.getStatValueText(SoldierRank.Squaddie, Stat.HP);
            tCorporalHp.Text = soldierClass.getStatValueText(SoldierRank.Corporal, Stat.HP);
            tSergeantHp.Text = soldierClass.getStatValueText(SoldierRank.Sergeant, Stat.HP);
            tLieutenantHp.Text = soldierClass.getStatValueText(SoldierRank.Lieutenant, Stat.HP);
            tCaptainHp.Text = soldierClass.getStatValueText(SoldierRank.Captain, Stat.HP);
            tMajorHp.Text = soldierClass.getStatValueText(SoldierRank.Major, Stat.HP);
            tColonelHp.Text = soldierClass.getStatValueText(SoldierRank.Colonel, Stat.HP);
            tBrigadierHp.Text = soldierClass.getStatValueText(SoldierRank.Brigadier, Stat.HP);

            tSquaddieAim.Text = soldierClass.getStatValueText(SoldierRank.Squaddie, Stat.Aim);
            tCorporalAim.Text = soldierClass.getStatValueText(SoldierRank.Corporal, Stat.Aim);
            tSergeantAim.Text = soldierClass.getStatValueText(SoldierRank.Sergeant, Stat.Aim);
            tLieutenantAim.Text = soldierClass.getStatValueText(SoldierRank.Lieutenant, Stat.Aim);
            tCaptainAim.Text = soldierClass.getStatValueText(SoldierRank.Captain, Stat.Aim);
            tMajorAim.Text = soldierClass.getStatValueText(SoldierRank.Major, Stat.Aim);
            tColonelAim.Text = soldierClass.getStatValueText(SoldierRank.Colonel, Stat.Aim);
            tBrigadierAim.Text = soldierClass.getStatValueText(SoldierRank.Brigadier, Stat.Aim);

            tSquaddieStrength.Text = soldierClass.getStatValueText(SoldierRank.Squaddie, Stat.Strength);
            tCorporalStrength.Text = soldierClass.getStatValueText(SoldierRank.Corporal, Stat.Strength);
            tSergeantStrength.Text = soldierClass.getStatValueText(SoldierRank.Sergeant, Stat.Strength);
            tLieutenantStrength.Text = soldierClass.getStatValueText(SoldierRank.Lieutenant, Stat.Strength);
            tCaptainStrength.Text = soldierClass.getStatValueText(SoldierRank.Captain, Stat.Strength);
            tMajorStrength.Text = soldierClass.getStatValueText(SoldierRank.Major, Stat.Strength);
            tColonelStrength.Text = soldierClass.getStatValueText(SoldierRank.Colonel, Stat.Strength);
            tBrigadierStrength.Text = soldierClass.getStatValueText(SoldierRank.Brigadier, Stat.Strength);

            tSquaddieHacking.Text = soldierClass.getStatValueText(SoldierRank.Squaddie, Stat.Hacking);
            tCorporalHacking.Text = soldierClass.getStatValueText(SoldierRank.Corporal, Stat.Hacking);
            tSergeantHacking.Text = soldierClass.getStatValueText(SoldierRank.Sergeant, Stat.Hacking);
            tLieutenantHacking.Text = soldierClass.getStatValueText(SoldierRank.Lieutenant, Stat.Hacking);
            tCaptainHacking.Text = soldierClass.getStatValueText(SoldierRank.Captain, Stat.Hacking);
            tMajorHacking.Text = soldierClass.getStatValueText(SoldierRank.Major, Stat.Hacking);
            tColonelHacking.Text = soldierClass.getStatValueText(SoldierRank.Colonel, Stat.Hacking);
            tBrigadierHacking.Text = soldierClass.getStatValueText(SoldierRank.Brigadier, Stat.Hacking);

            tSquaddiePsi.Text = soldierClass.getStatValueText(SoldierRank.Squaddie, Stat.Psi);
            tCorporalPsi.Text = soldierClass.getStatValueText(SoldierRank.Corporal, Stat.Psi);
            tSergeantPsi.Text = soldierClass.getStatValueText(SoldierRank.Sergeant, Stat.Psi);
            tLieutenantPsi.Text = soldierClass.getStatValueText(SoldierRank.Lieutenant, Stat.Psi);
            tCaptainPsi.Text = soldierClass.getStatValueText(SoldierRank.Captain, Stat.Psi);
            tMajorPsi.Text = soldierClass.getStatValueText(SoldierRank.Major, Stat.Psi);
            tColonelPsi.Text = soldierClass.getStatValueText(SoldierRank.Colonel, Stat.Psi);
            tBrigadierPsi.Text = soldierClass.getStatValueText(SoldierRank.Brigadier, Stat.Psi);

            tSquaddieMobility.Text = soldierClass.getStatValueText(SoldierRank.Squaddie, Stat.Mobility);
            tCorporalMobility.Text = soldierClass.getStatValueText(SoldierRank.Corporal, Stat.Mobility);
            tSergeantMobility.Text = soldierClass.getStatValueText(SoldierRank.Sergeant, Stat.Mobility);
            tLieutenantMobility.Text = soldierClass.getStatValueText(SoldierRank.Lieutenant, Stat.Mobility);
            tCaptainMobility.Text = soldierClass.getStatValueText(SoldierRank.Captain, Stat.Mobility);
            tMajorMobility.Text = soldierClass.getStatValueText(SoldierRank.Major, Stat.Mobility);
            tColonelMobility.Text = soldierClass.getStatValueText(SoldierRank.Colonel, Stat.Mobility);
            tBrigadierMobility.Text = soldierClass.getStatValueText(SoldierRank.Brigadier, Stat.Mobility);

            tSquaddieWill.Text = soldierClass.getStatValueText(SoldierRank.Squaddie, Stat.Will);
            tCorporalWill.Text = soldierClass.getStatValueText(SoldierRank.Corporal, Stat.Will);
            tSergeantWill.Text = soldierClass.getStatValueText(SoldierRank.Sergeant, Stat.Will);
            tLieutenantWill.Text = soldierClass.getStatValueText(SoldierRank.Lieutenant, Stat.Will);
            tCaptainWill.Text = soldierClass.getStatValueText(SoldierRank.Captain, Stat.Will);
            tMajorWill.Text = soldierClass.getStatValueText(SoldierRank.Major, Stat.Will);
            tColonelWill.Text = soldierClass.getStatValueText(SoldierRank.Colonel, Stat.Will);
            tBrigadierWill.Text = soldierClass.getStatValueText(SoldierRank.Brigadier, Stat.Will);

            tSquaddieDodge.Text = soldierClass.getStatValueText(SoldierRank.Squaddie, Stat.Dodge);
            tCorporalDodge.Text = soldierClass.getStatValueText(SoldierRank.Corporal, Stat.Dodge);
            tSergeantDodge.Text = soldierClass.getStatValueText(SoldierRank.Sergeant, Stat.Dodge);
            tLieutenantDodge.Text = soldierClass.getStatValueText(SoldierRank.Lieutenant, Stat.Dodge);
            tCaptainDodge.Text = soldierClass.getStatValueText(SoldierRank.Captain, Stat.Dodge);
            tMajorDodge.Text = soldierClass.getStatValueText(SoldierRank.Major, Stat.Dodge);
            tColonelDodge.Text = soldierClass.getStatValueText(SoldierRank.Colonel, Stat.Dodge);
            tBrigadierDodge.Text = soldierClass.getStatValueText(SoldierRank.Brigadier, Stat.Dodge);
        }
    }
}
