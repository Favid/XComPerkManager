using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ini;
using System.IO;
using XcomPerkManager.Forms;

namespace XcomPerkManager
{
    public partial class ClassOverview : Form
    {
        public SoldierClass currentSoldier { get; set; }
        public List<SoldierClass> soldiers { get; set; }
        public List<Ability> abilities { get; set; }

        public ClassOverview()
        {
            InitializeComponent();
        }

        private void bEditAbilities_Click(object sender, EventArgs e)
        {
            AbilityManager manager = new AbilityManager();
            manager.Show(this);
        }

        private void bEditMetadata_Click(object sender, EventArgs e)
        {
            MetadataManager manager = new MetadataManager();
            manager.Show(this);
        }

        private void bEditExperience_Click(object sender, EventArgs e)
        {
            ExperienceManager manager = new ExperienceManager();
            manager.Show(this);
        }

        private void bEditEquipment_Click(object sender, EventArgs e)
        {
            EquipmentManager manager = new EquipmentManager();
            manager.Show(this);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            SoldierClass soldierClass = new SoldierClass();
            soldierClass.metadata.internalName = "Test";

            

            MetadataManager manager = new MetadataManager();
            manager.newClass = true;
            manager.Show(this);
        }

        private void ClassOverview_Load(object sender, EventArgs e)
        {
            XComAbilityListReader reader = new XComAbilityListReader();
            abilities = reader.read();

            updateSoldiers();
        }

        public void updateSoldiers()
        {
            SavedSoldiersReader xmlReader = new SavedSoldiersReader(abilities);
            soldiers = xmlReader.read();

            cClass.DataSource = soldiers;
        }

        public void selectSoldier(string internalName)
        {
            SoldierClass soldierClass = soldiers.Where(x => x.metadata.internalName.Equals(internalName)).FirstOrDefault();
            cClass.SelectedIndex = cClass.Items.IndexOf(soldierClass);
        }

        private void cClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSoldier = soldiers.Where(x => x.metadata.internalName.Equals(cClass.SelectedValue.ToString())).FirstOrDefault();
            displayClass(currentSoldier);
        }

        public void displayClass(SoldierClass soldierClass)
        {
            displayMetadata(soldierClass.metadata);
            displayExperience(soldierClass.experience);
            displayEquipment(soldierClass.equipment);
            displayAbilities(soldierClass.soldierAbilities);
            displayStats(soldierClass.stats);
        }

        public void displayMetadata(SoldierClassMetadata metadata)
        {
            laMetadataInternalName.Text = metadata.internalName;
            laMetadataDisplayName.Text = metadata.displayName;
            laMetadataDescription.Text = metadata.description;
            laMetadataIconString.Text = metadata.iconString;
        }

        public void displayExperience(SoldierClassExperience experience)
        {
            laExperienceNumberInForcedDeck.Text = experience.numberInForcedDeck.ToString();
            laExperienceNumberInDeck.Text = experience.numberInDeck.ToString();
            laExperienceKillAssistsPerKill.Text = experience.killAssistsPerKill.ToString();
        }

        public void displayEquipment(SoldierClassEquipment equipment)
        {
            laEquipmentSquaddieLoadout.Text = equipment.squaddieLoadout;
            laEquipmentPrimaryWeapon.Text = equipment.primaryWeapon;
            laEquipmentSecondaryWeapon.Text = equipment.secondaryWeapon;
            laEquipmentAllowedArmors.Text = equipment.allowedArmors;
        }

        public void displayAbilities(List<SoldierClassAbility> soldierAbilities)
        {
            laAbilitiesSquaddie1.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Squaddie, 1);
            laAbilitiesSquaddie2.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Squaddie, 2);
            laAbilitiesSquaddie3.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Squaddie, 3);
            laAbilitiesSquaddie4.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Squaddie, 4);
            laAbilitiesSquaddie5.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Squaddie, 5);
            laAbilitiesSquaddie6.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Squaddie, 6);

            laAbilitiesCorporal1.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Corporal, 1);
            laAbilitiesCorporal2.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Corporal, 2);
            laAbilitiesCorporal3.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Corporal, 3);

            laAbilitiesSergeant1.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Sergeant, 1);
            laAbilitiesSergeant2.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Sergeant, 2);
            laAbilitiesSergeant3.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Sergeant, 3);

            laAbilitiesLieutenant1.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Lieutenant, 1);
            laAbilitiesLieutenant2.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Lieutenant, 2);
            laAbilitiesLieutenant3.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Lieutenant, 3);

            laAbilitiesCaptain1.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Captain, 1);
            laAbilitiesCaptain2.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Captain, 2);
            laAbilitiesCaptain3.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Captain, 3);

            laAbilitiesMajor1.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Major, 1);
            laAbilitiesMajor2.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Major, 2);
            laAbilitiesMajor3.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Major, 3);

            laAbilitiesColonel1.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Colonel, 1);
            laAbilitiesColonel2.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Colonel, 2);
            laAbilitiesColonel3.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Colonel, 3);

            laAbilitiesBrigadier1.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Brigadier, 1);
            laAbilitiesBrigadier2.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Brigadier, 2);
            laAbilitiesBrigadier3.Text = getInternalNameFromList(soldierAbilities, SoldierRank.Brigadier, 3);
        }

        public void displayStats(List<SoldierClassStat> soldierStats)
        {
            laHpSquaddie.Text = getDisplayValueForStat(soldierStats, SoldierRank.Squaddie, Stat.HP);
            laHpCorporal.Text = getDisplayValueForStat(soldierStats, SoldierRank.Corporal, Stat.HP);
            laHpSergeant.Text = getDisplayValueForStat(soldierStats, SoldierRank.Sergeant, Stat.HP);
            laHpLieutenant.Text = getDisplayValueForStat(soldierStats, SoldierRank.Lieutenant, Stat.HP);
            laHpCaptain.Text = getDisplayValueForStat(soldierStats, SoldierRank.Captain, Stat.HP);
            laHpMajor.Text = getDisplayValueForStat(soldierStats, SoldierRank.Major, Stat.HP);
            laHpColonel.Text = getDisplayValueForStat(soldierStats, SoldierRank.Colonel, Stat.HP);
            laHpBrigadier.Text = getDisplayValueForStat(soldierStats, SoldierRank.Brigadier, Stat.HP);
            
            laAimSquaddie.Text = getDisplayValueForStat(soldierStats, SoldierRank.Squaddie, Stat.Aim);
            laAimCorporal.Text = getDisplayValueForStat(soldierStats, SoldierRank.Corporal, Stat.Aim);
            laAimSergeant.Text = getDisplayValueForStat(soldierStats, SoldierRank.Sergeant, Stat.Aim);
            laAimLieutenant.Text = getDisplayValueForStat(soldierStats, SoldierRank.Lieutenant, Stat.Aim);
            laAimCaptain.Text = getDisplayValueForStat(soldierStats, SoldierRank.Captain, Stat.Aim);
            laAimMajor.Text = getDisplayValueForStat(soldierStats, SoldierRank.Major, Stat.Aim);
            laAimColonel.Text = getDisplayValueForStat(soldierStats, SoldierRank.Colonel, Stat.Aim);
            laAimBrigadier.Text = getDisplayValueForStat(soldierStats, SoldierRank.Brigadier, Stat.Aim);
            
            laStrengthSquaddie.Text = getDisplayValueForStat(soldierStats, SoldierRank.Squaddie, Stat.Strength);
            laStrengthCorporal.Text = getDisplayValueForStat(soldierStats, SoldierRank.Corporal, Stat.Strength);
            laStrengthSergeant.Text = getDisplayValueForStat(soldierStats, SoldierRank.Sergeant, Stat.Strength);
            laStrengthLieutenant.Text = getDisplayValueForStat(soldierStats, SoldierRank.Lieutenant, Stat.Strength);
            laStrengthCaptain.Text = getDisplayValueForStat(soldierStats, SoldierRank.Captain, Stat.Strength);
            laStrengthMajor.Text = getDisplayValueForStat(soldierStats, SoldierRank.Major, Stat.Strength);
            laStrengthColonel.Text = getDisplayValueForStat(soldierStats, SoldierRank.Colonel, Stat.Strength);
            laStrengthBrigadier.Text = getDisplayValueForStat(soldierStats, SoldierRank.Brigadier, Stat.Strength);

            laHackingSquaddie.Text = getDisplayValueForStat(soldierStats, SoldierRank.Squaddie, Stat.Hacking);
            laHackingCorporal.Text = getDisplayValueForStat(soldierStats, SoldierRank.Corporal, Stat.Hacking);
            laHackingSergeant.Text = getDisplayValueForStat(soldierStats, SoldierRank.Sergeant, Stat.Hacking);
            laHackingLieutenant.Text = getDisplayValueForStat(soldierStats, SoldierRank.Lieutenant, Stat.Hacking);
            laHackingCaptain.Text = getDisplayValueForStat(soldierStats, SoldierRank.Captain, Stat.Hacking);
            laHackingMajor.Text = getDisplayValueForStat(soldierStats, SoldierRank.Major, Stat.Hacking);
            laHackingColonel.Text = getDisplayValueForStat(soldierStats, SoldierRank.Colonel, Stat.Hacking);
            laHackingBrigadier.Text = getDisplayValueForStat(soldierStats, SoldierRank.Brigadier, Stat.Hacking);

            laPsiSquaddie.Text = getDisplayValueForStat(soldierStats, SoldierRank.Squaddie, Stat.Psi);
            laPsiCorporal.Text = getDisplayValueForStat(soldierStats, SoldierRank.Corporal, Stat.Psi);
            laPsiSergeant.Text = getDisplayValueForStat(soldierStats, SoldierRank.Sergeant, Stat.Psi);
            laPsiLieutenant.Text = getDisplayValueForStat(soldierStats, SoldierRank.Lieutenant, Stat.Psi);
            laPsiCaptain.Text = getDisplayValueForStat(soldierStats, SoldierRank.Captain, Stat.Psi);
            laPsiMajor.Text = getDisplayValueForStat(soldierStats, SoldierRank.Major, Stat.Psi);
            laPsiColonel.Text = getDisplayValueForStat(soldierStats, SoldierRank.Colonel, Stat.Psi);
            laPsiBrigadier.Text = getDisplayValueForStat(soldierStats, SoldierRank.Brigadier, Stat.Psi);
        }

        // TODO refactor
        private string getInternalNameFromList(List<SoldierClassAbility> soldierAbilities, SoldierRank rank, int slot)
        {
            return soldierAbilities.Where(x => x.rank == rank && x.slot == slot).Select(x => x.displayName).FirstOrDefault();
        }

        private string getDisplayValueForStat(List<SoldierClassStat> soldierStats, SoldierRank rank, Stat stat)
        {
            return soldierStats.Where(x => x.rank == rank && x.stat == stat).Select(x => x.value.ToString()).FirstOrDefault();
        }

        private string getDescriptionFromList(SoldierRank rank, int slot)
        {
            return currentSoldier.soldierAbilities.Where(x => x.rank == rank && x.slot == slot).Select(x => x.description).FirstOrDefault();
        }

        private void bEditStats_Click(object sender, EventArgs e)
        {
            StatManager manager = new StatManager();
            manager.Show(this);
        }

        private void bIni_Click(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(currentDir);
            DirectoryInfo root = directory.Parent.Parent;
            string fullPath = Path.Combine(root.FullName, "test.ini");


            IniFile iniFile = new IniFile(fullPath);

            iniFile.IniWriteValue("XComGame.X2SoldierClass_DefaultClasses", "+SoldierClasses", Utils.encaseStringInQuotes(currentSoldier.metadata.internalName));

            string classSection = currentSoldier.metadata.internalName + " X2SoldierClassTemplate";
            iniFile.IniWriteValue(classSection, "+bMultiplayerOnly", "0");
            iniFile.IniWriteValue(classSection, "+ClassPoints", "5");
            iniFile.IniWriteValue(classSection, "+IconImage", Utils.encaseStringInQuotes(currentSoldier.metadata.iconString));
            iniFile.IniWriteValue(classSection, "+NumInForcedDeck", currentSoldier.experience.numberInForcedDeck.ToString());
            iniFile.IniWriteValue(classSection, "+NumInDeck", currentSoldier.experience.numberInDeck.ToString());
            iniFile.IniWriteValue(classSection, "+KillAssistsPerKill", currentSoldier.experience.killAssistsPerKill.ToString());
            iniFile.IniWriteValue(classSection, "+SquaddieLoadout", Utils.encaseStringInQuotes(currentSoldier.equipment.squaddieLoadout));

            string primaryWeaponString = "(SlotType=eInvSlot_PrimaryWeapon, WeaponType=" + Utils.encaseStringInQuotes(currentSoldier.equipment.primaryWeapon) + ")";
            iniFile.IniWriteValue(classSection, "+AllowedWeapons", primaryWeaponString);

            string secondaryWeaponString = "(SlotType=eInvSlot_SecondaryWeapon, WeaponType=" + Utils.encaseStringInQuotes(currentSoldier.equipment.secondaryWeapon) + ")";
            iniFile.IniWriteValue(classSection, "+AllowedWeapons", secondaryWeaponString);

            iniFile.IniWriteValue(classSection, "+AllowedArmors", Utils.encaseStringInQuotes(currentSoldier.equipment.allowedArmors));

            iniFile.IniWriteValue(classSection, "+bAllowAWCAbilities", "1"); // TODO actually do this

            // TODO Exlude AWC Abilities

            iniFile.IniWriteValue(classSection, "+bHasClassMovie", "false"); // TODO actually do this

            // abilities time wooooooooo

            currentSoldier.soldierAbilities = currentSoldier.soldierAbilities.OrderBy(x => x.rank).ThenBy(x => x.slot).ToList();

            // squaddie
            string soldierRankSquaddie = "( aAbilityTree=(";

            List<SoldierClassAbility> squaddieAbilities = currentSoldier.soldierAbilities.Where(x => x.rank == SoldierRank.Squaddie).OrderBy(x => x.slot).ToList();

            string fullAbility = "";

            foreach(SoldierClassAbility squaddieAbility in squaddieAbilities)
            {
                if(!string.IsNullOrEmpty(squaddieAbility.internalName))
                {
                    string thisAbility = "";
                    if (!string.IsNullOrEmpty(fullAbility))
                    {
                        thisAbility = ",";
                    }

                    thisAbility += "(AbilityName=" + Utils.encaseStringInQuotes(squaddieAbility.internalName) + ", ApplyToWeaponSlot=" + getIniWeaponSlot(squaddieAbility.weaponSlot) + ")";
                    fullAbility += thisAbility;
                }
            }

            List<SoldierClassStat> squaddieStats = currentSoldier.stats.Where(x => x.rank == SoldierRank.Squaddie).OrderBy(x => x.stat).ToList();

            string fullStat = "";

            foreach(SoldierClassStat squaddieStat in squaddieStats)
            {
                if(squaddieStat.value > 0)
                {
                    string thisStat = "";
                    if (!string.IsNullOrEmpty(fullStat))
                    {
                        thisStat = ",";
                    }

                    thisStat += "(StatType=" + squaddieStat.stat + ",StatAmount=" + squaddieStat.value.ToString() + ")";
                    fullStat += thisStat;
                }
            }

            fullStat = "aStatProgression=(" + fullStat + ")";


            soldierRankSquaddie += fullAbility + "), " + fullStat + ")";

            iniFile.IniWriteValue(classSection, "+SoldierRanks", soldierRankSquaddie); 


        }

        private string getIniWeaponSlot(WeaponSlot weaponSlot)
        {
            switch(weaponSlot)
            {
                case WeaponSlot.Primary:
                    return "eInvSlot_PrimaryWeapon";

                case WeaponSlot.Secondary:
                    return "eInvSlot_SecondaryWeapon";

                case WeaponSlot.Unknown:
                    return "eInvSlot_Unknown";

                case WeaponSlot.None:
                    return "";
            }

            return "";
        }

        #region Ability label click events

        private void laAbilitiesCorporal1_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Corporal, 1);
        }

        private void laAbilitiesCorporal2_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Corporal, 2);
        }

        private void laAbilitiesCorporal3_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Corporal, 3);
        }

        private void laAbilitiesSquaddie1_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Squaddie, 1);
        }

        private void laAbilitiesSquaddie2_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Squaddie, 2);
        }

        private void laAbilitiesSquaddie3_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Squaddie, 3);
        }

        private void laAbilitiesSquaddie4_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Squaddie, 4);
        }

        private void laAbilitiesSquaddie5_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Squaddie, 5);
        }

        private void laAbilitiesSquaddie6_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Squaddie, 6);
        }

        private void laAbilitiesSergeant1_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Sergeant, 1);
        }

        private void laAbilitiesCaptain2_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Captain, 2);
        }

        private void laAbilitiesCaptain1_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Captain, 1);
        }

        private void laAbilitiesMajor3_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Major, 3);
        }

        private void laAbilitiesMajor2_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Major, 2);
        }

        private void laAbilitiesMajor1_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Major, 1);
        }

        private void laAbilitiesColonel3_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Colonel, 3);
        }

        private void laAbilitiesColonel2_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Colonel, 2);
        }

        private void laAbilitiesColonel1_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Colonel, 1);
        }

        private void laAbilitiesBrigadier3_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Brigadier, 3);
        }

        private void laAbilitiesBrigadier2_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Brigadier, 2);
        }

        private void laAbilitiesBrigadier1_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Brigadier, 1);
        }

        private void laAbilitiesLieutenant3_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Lieutenant, 3);
        }

        private void laAbilitiesLieutenant2_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Lieutenant, 2);
        }

        private void laAbilitiesLieutenant1_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Lieutenant, 1);
        }

        private void laAbilitiesSergeant3_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Sergeant, 3);
        }

        private void laAbilitiesSergeant2_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Sergeant, 2);
        }

        private void laAbilitiesCaptain3_Click(object sender, EventArgs e)
        {
            laHelp.Text = getDescriptionFromList(SoldierRank.Captain, 3);
        }

        #endregion Ability label click events

        #region Stat label click events

        private void laHp_Click(object sender, EventArgs e)
        {
            laHelp.Text = "Number of health points gained when ranking up.";
        }

        private void laAim_Click(object sender, EventArgs e)
        {
            laHelp.Text = "Amount of Aim gained when ranking up.";
        }

        private void laStrength_Click(object sender, EventArgs e)
        {
            laHelp.Text = "Amount of Strength gained when ranking up. "
                + "NOTE: I do not know what this does. "
                + "It may have something to do with either melee accuracy, or melee counter-attacks like the Muton has. "
                + "If anyone knows exactly what this does, please let me know so I can update this description.";
        }

        private void laHacking_Click(object sender, EventArgs e)
        {
            laHelp.Text = "Number of hacking points gained when ranking up.";
        }

        private void laPsi_Click(object sender, EventArgs e)
        {
            laHelp.Text = "Number of Psi Offense points gained when ranking up."
                + "Affects the strength and accurracy of many Psi-related abilities."
                + "NOTE: By default, this value is only displayed in-game to the player for soldiers of the Psi Operative class.";
        }

        #endregion Stat label click events

        private void bTest_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
