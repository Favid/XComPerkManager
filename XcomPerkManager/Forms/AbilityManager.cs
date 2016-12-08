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
    public partial class AbilityManager : Form
    {
        private string formerInternalName;

        public AbilityManager()
        {
            InitializeComponent();
        }

        private void AbilityManager_Load(object sender, EventArgs e)
        {
            ClassOverview owner = Owner as ClassOverview;
            formerInternalName = owner.currentSoldier.metadata.internalName;

            foreach (Control control in Controls)
            {
                ComboBox combo = control as ComboBox;

                if(combo != null)
                {
                    List<Ability> abilitiesCopy = owner.abilities.ToList();
                    abilitiesCopy.Add(new Ability());
                    abilitiesCopy = abilitiesCopy.OrderBy(x => x.internalName).ToList();

                    combo.DataSource = abilitiesCopy;
                }
            }

            setCombos();
        }

        private void setCombos()
        {
            setCombo(cSquaddie1, SoldierRank.Squaddie, 1);
            setCombo(cSquaddie2, SoldierRank.Squaddie, 2);
            setCombo(cSquaddie3, SoldierRank.Squaddie, 3);
            setCombo(cSquaddie4, SoldierRank.Squaddie, 4);
            setCombo(cSquaddie5, SoldierRank.Squaddie, 5);
            setCombo(cSquaddie6, SoldierRank.Squaddie, 6);

            setCombo(cCorporal1, SoldierRank.Corporal, 1);
            setCombo(cCorporal2, SoldierRank.Corporal, 2);
            setCombo(cCorporal3, SoldierRank.Corporal, 3);

            setCombo(cSergeant1, SoldierRank.Sergeant, 1);
            setCombo(cSergeant2, SoldierRank.Sergeant, 2);
            setCombo(cSergeant3, SoldierRank.Sergeant, 3);

            setCombo(cLieutenant1, SoldierRank.Lieutenant, 1);
            setCombo(cLieutenant2, SoldierRank.Lieutenant, 2);
            setCombo(cLieutenant3, SoldierRank.Lieutenant, 3);

            setCombo(cCaptain1, SoldierRank.Captain, 1);
            setCombo(cCaptain2, SoldierRank.Captain, 2);
            setCombo(cCaptain3, SoldierRank.Captain, 3);

            setCombo(cMajor1, SoldierRank.Major, 1);
            setCombo(cMajor2, SoldierRank.Major, 2);
            setCombo(cMajor3, SoldierRank.Major, 3);

            setCombo(cColonel1, SoldierRank.Colonel, 1);
            setCombo(cColonel2, SoldierRank.Colonel, 2);
            setCombo(cColonel3, SoldierRank.Colonel, 3);

            setCombo(cBrigadier1, SoldierRank.Brigadier, 1);
            setCombo(cBrigadier2, SoldierRank.Brigadier, 2);
            setCombo(cBrigadier3, SoldierRank.Brigadier, 3);
        }

        private void setCombo(ComboBox combo, SoldierRank rank, int slot)
        {
            combo.SelectedIndex = combo.Items.IndexOf(getAbilityForCombo(rank, slot));
        }

        private Ability getAbilityForCombo(string abilityInternalName)
        {
            ClassOverview owner = Owner as ClassOverview;

            SoldierClassAbility soldierAbility = owner.currentSoldier.soldierAbilities.Where(x => x.internalName == abilityInternalName).FirstOrDefault();

            if (soldierAbility != null)
            {
                return soldierAbility.getAbility();
            }

            return new Ability();
        }

        private Ability getAbilityForCombo(SoldierRank rank, int slot)
        {
            ClassOverview owner = Owner as ClassOverview;

            SoldierClassAbility soldierAbility = owner.currentSoldier.soldierAbilities.Where(x => x.rank == rank && x.slot == slot).FirstOrDefault();

            if(soldierAbility != null)
            {
                return soldierAbility.getAbility();
            }

            return new Ability();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ClassOverview owner = Owner as ClassOverview;

            List<SoldierClassAbility> soldierAbilities = new List<SoldierClassAbility>();

            soldierAbilities.Add(buildSoldierAbilityFromCombo(cSquaddie1, SoldierRank.Squaddie, 1));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cSquaddie2, SoldierRank.Squaddie, 2));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cSquaddie3, SoldierRank.Squaddie, 3));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cSquaddie4, SoldierRank.Squaddie, 4));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cSquaddie5, SoldierRank.Squaddie, 5));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cSquaddie6, SoldierRank.Squaddie, 6));

            soldierAbilities.Add(buildSoldierAbilityFromCombo(cCorporal1, SoldierRank.Corporal, 1));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cCorporal2, SoldierRank.Corporal, 2));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cCorporal3, SoldierRank.Corporal, 3));

            soldierAbilities.Add(buildSoldierAbilityFromCombo(cSergeant1, SoldierRank.Sergeant, 1));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cSergeant2, SoldierRank.Sergeant, 2));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cSergeant3, SoldierRank.Sergeant, 3));

            soldierAbilities.Add(buildSoldierAbilityFromCombo(cLieutenant1, SoldierRank.Lieutenant, 1));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cLieutenant2, SoldierRank.Lieutenant, 2));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cLieutenant3, SoldierRank.Lieutenant, 3));

            soldierAbilities.Add(buildSoldierAbilityFromCombo(cCaptain1, SoldierRank.Captain, 1));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cCaptain2, SoldierRank.Captain, 2));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cCaptain3, SoldierRank.Captain, 3));

            soldierAbilities.Add(buildSoldierAbilityFromCombo(cMajor1, SoldierRank.Major, 1));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cMajor2, SoldierRank.Major, 2));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cMajor3, SoldierRank.Major, 3));

            soldierAbilities.Add(buildSoldierAbilityFromCombo(cColonel1, SoldierRank.Colonel, 1));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cColonel2, SoldierRank.Colonel, 2));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cColonel3, SoldierRank.Colonel, 3));

            soldierAbilities.Add(buildSoldierAbilityFromCombo(cBrigadier1, SoldierRank.Brigadier, 1));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cBrigadier2, SoldierRank.Brigadier, 2));
            soldierAbilities.Add(buildSoldierAbilityFromCombo(cBrigadier3, SoldierRank.Brigadier, 3));

            SavedSoldiersManager manager = new SavedSoldiersManager();
            manager.updateAbilitiesElement(formerInternalName, soldierAbilities);
            
            owner.updateSoldiers();
            owner.selectSoldier(formerInternalName);

            Close();
        }

        private SoldierClassAbility buildSoldierAbilityFromCombo(ComboBox combo, SoldierRank rank, int slot)
        {
            SoldierClassAbility soldierAbility = new SoldierClassAbility();
            Ability comboAbility = combo.SelectedItem as Ability;

            if(comboAbility != null)
            {
                soldierAbility.internalName = comboAbility.internalName;
                soldierAbility.displayName = comboAbility.displayName;
                soldierAbility.description = comboAbility.description;
                soldierAbility.weaponSlot = comboAbility.weaponSlot;
                soldierAbility.requiredMod = comboAbility.requiredMod;
                soldierAbility.rank = rank;
                soldierAbility.slot = slot;
            }
            
            return soldierAbility;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cAbility_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;

            if(combo != null)
            {
                Ability ability = combo.SelectedItem as Ability;

                if(ability != null)
                {
                    laHelp.Text = ability.description;
                }
            }
        }

        private void cAbility_MouseDown(object sender, MouseEventArgs e)
        {
            //cSquaddie1.DoDragDrop(cSquaddie1.Text, DragDropEffects.Copy);

            ComboBox comboSender = sender as ComboBox;
            comboSender.DoDragDrop(comboSender, DragDropEffects.Copy);
        }

        private void cAbility_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.Text))
            //    e.Effect = DragDropEffects.Copy;
            //else
            //    e.Effect = DragDropEffects.None;

            e.Effect = DragDropEffects.Copy;
        }

        private void cAbility_DragDrop(object sender, DragEventArgs e)
        {
            //cSquaddie1.Text = cSquaddie2.Text;
            //cSquaddie2.Text = e.Data.GetData(DataFormats.Text).ToString();

            ComboBox comboSender = sender as ComboBox;
            ComboBox comboDragged = e.Data.GetData(typeof(ComboBox)) as ComboBox;

            string temp = comboSender.Text;
            //comboSender.Text = comboDragged.Text;
            comboSender.SelectedIndex = comboSender.Items.IndexOf(getAbilityForCombo(comboDragged.Text));
            //comboDragged.Text = temp;
            comboDragged.SelectedIndex = comboSender.Items.IndexOf(getAbilityForCombo(temp));
        }
    }
}
