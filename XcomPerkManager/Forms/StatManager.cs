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
    public partial class StatManager : Form
    {
        private string formerInternalName;

        public StatManager()
        {
            InitializeComponent();
        }

        private void StatManager_Load(object sender, EventArgs e)
        {
            ClassOverview owner = Owner as ClassOverview;
            formerInternalName = owner.currentSoldier.metadata.internalName;

            tSquaddieHp.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Squaddie && x.stat == Stat.HP).Select(x => x.value.ToString()).FirstOrDefault();
            tCorporalHp.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Corporal && x.stat == Stat.HP).Select(x => x.value.ToString()).FirstOrDefault();
            tSergeantHp.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Sergeant && x.stat == Stat.HP).Select(x => x.value.ToString()).FirstOrDefault();
            tLieutenantHp.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Lieutenant && x.stat == Stat.HP).Select(x => x.value.ToString()).FirstOrDefault();
            tCaptainHp.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Captain && x.stat == Stat.HP).Select(x => x.value.ToString()).FirstOrDefault();
            tMajorHp.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Major && x.stat == Stat.HP).Select(x => x.value.ToString()).FirstOrDefault();
            tColonelHp.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Colonel && x.stat == Stat.HP).Select(x => x.value.ToString()).FirstOrDefault();
            tBrigadierHp.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Brigadier && x.stat == Stat.HP).Select(x => x.value.ToString()).FirstOrDefault();

            tSquaddieAim.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Squaddie && x.stat == Stat.Aim).Select(x => x.value.ToString()).FirstOrDefault();
            tCorporalAim.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Corporal && x.stat == Stat.Aim).Select(x => x.value.ToString()).FirstOrDefault();
            tSergeantAim.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Sergeant && x.stat == Stat.Aim).Select(x => x.value.ToString()).FirstOrDefault();
            tLieutenantAim.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Lieutenant && x.stat == Stat.Aim).Select(x => x.value.ToString()).FirstOrDefault();
            tCaptainAim.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Captain && x.stat == Stat.Aim).Select(x => x.value.ToString()).FirstOrDefault();
            tMajorAim.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Major && x.stat == Stat.Aim).Select(x => x.value.ToString()).FirstOrDefault();
            tColonelAim.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Colonel && x.stat == Stat.Aim).Select(x => x.value.ToString()).FirstOrDefault();
            tBrigadierAim.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Brigadier && x.stat == Stat.Aim).Select(x => x.value.ToString()).FirstOrDefault();

            tSquaddieStrength.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Squaddie && x.stat == Stat.Strength).Select(x => x.value.ToString()).FirstOrDefault();
            tCorporalStrength.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Corporal && x.stat == Stat.Strength).Select(x => x.value.ToString()).FirstOrDefault();
            tSergeantStrength.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Sergeant && x.stat == Stat.Strength).Select(x => x.value.ToString()).FirstOrDefault();
            tLieutenantStrength.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Lieutenant && x.stat == Stat.Strength).Select(x => x.value.ToString()).FirstOrDefault();
            tCaptainStrength.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Captain && x.stat == Stat.Strength).Select(x => x.value.ToString()).FirstOrDefault();
            tMajorStrength.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Major && x.stat == Stat.Strength).Select(x => x.value.ToString()).FirstOrDefault();
            tColonelStrength.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Colonel && x.stat == Stat.Strength).Select(x => x.value.ToString()).FirstOrDefault();
            tBrigadierStrength.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Brigadier && x.stat == Stat.Strength).Select(x => x.value.ToString()).FirstOrDefault();

            tSquaddieHacking.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Squaddie && x.stat == Stat.Hacking).Select(x => x.value.ToString()).FirstOrDefault();
            tCorporalHacking.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Corporal && x.stat == Stat.Hacking).Select(x => x.value.ToString()).FirstOrDefault();
            tSergeantHacking.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Sergeant && x.stat == Stat.Hacking).Select(x => x.value.ToString()).FirstOrDefault();
            tLieutenantHacking.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Lieutenant && x.stat == Stat.Hacking).Select(x => x.value.ToString()).FirstOrDefault();
            tCaptainHacking.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Captain && x.stat == Stat.Hacking).Select(x => x.value.ToString()).FirstOrDefault();
            tMajorHacking.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Major && x.stat == Stat.Hacking).Select(x => x.value.ToString()).FirstOrDefault();
            tColonelHacking.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Colonel && x.stat == Stat.Hacking).Select(x => x.value.ToString()).FirstOrDefault();
            tBrigadierHacking.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Brigadier && x.stat == Stat.Hacking).Select(x => x.value.ToString()).FirstOrDefault();

            tSquaddiePsi.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Squaddie && x.stat == Stat.Psi).Select(x => x.value.ToString()).FirstOrDefault();
            tCorporalPsi.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Corporal && x.stat == Stat.Psi).Select(x => x.value.ToString()).FirstOrDefault();
            tSergeantPsi.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Sergeant && x.stat == Stat.Psi).Select(x => x.value.ToString()).FirstOrDefault();
            tLieutenantPsi.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Lieutenant && x.stat == Stat.Psi).Select(x => x.value.ToString()).FirstOrDefault();
            tCaptainPsi.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Captain && x.stat == Stat.Psi).Select(x => x.value.ToString()).FirstOrDefault();
            tMajorPsi.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Major && x.stat == Stat.Psi).Select(x => x.value.ToString()).FirstOrDefault();
            tColonelPsi.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Colonel && x.stat == Stat.Psi).Select(x => x.value.ToString()).FirstOrDefault();
            tBrigadierPsi.Text = owner.currentSoldier.stats.Where(x => x.rank == SoldierRank.Brigadier && x.stat == Stat.Psi).Select(x => x.value.ToString()).FirstOrDefault();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ClassOverview owner = Owner as ClassOverview;

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

            SavedSoldiersManager manager = new SavedSoldiersManager();
            manager.updateStatsElement(formerInternalName, soldierStats);

            owner.updateSoldiers();
            owner.selectSoldier(formerInternalName);

            Close();
        }

        private SoldierClassStat buildSoldierStatFromControl(TextBox control, SoldierRank rank, Stat stat)
        {
            SoldierClassStat soldierStat = new SoldierClassStat();

            soldierStat.rank = rank;
            soldierStat.stat = stat;
            soldierStat.value = Utils.parseStringToInt(control.Text);

            return soldierStat;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
