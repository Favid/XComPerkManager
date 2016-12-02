using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XcomPerkManager
{
    #region Constants

    public static class Constants
    {
        public const string XML_CLASSES = "soldiers";
        public const string XML_CLASS = "soldier";

        public const string XML_METADATA = "metadata";
        public const string XML_METADATA_INTERNAL_NAME = "internal_name";
        public const string XML_METADATA_DISPLAY_NAME = "display_name";
        public const string XML_METADATA_DESCRIPTION = "description";
        public const string XML_METADATA_ICON_STRING = "icon_string";

        public const string XML_EXPERIENCE = "experience";
        public const string XML_EXPERIENCE_NUM_IN_FORCED_DECK = "number_in_forced_deck";
        public const string XML_EXPERIENCE_NUM_IN_DECK = "number_in_deck";
        public const string XML_EXPERIENCE_KILL_ASSISTS_PER_KILL = "kill_assists_per_kill";

        public const string XML_EQUIPMENT = "equipment";
        public const string XML_EQUIPMENT_SQUADDIE_LOADOUT = "squaddie_loadout";
        public const string XML_EQUIPMENT_PRIMARY_WEAPON = "primary_weapon";
        public const string XML_EQUIPMENT_SECONDARY_WEAPON = "secondary_weapon";
        public const string XML_EQUIPMENT_ALLOWED_ARMORS = "allowed_armors";

        public const string XML_ABILITIES = "abilities";
        public const string XML_ABILITY = "ability";
        public const string XML_ABILITY_INTERNAL_NAME = "internal_name";
        public const string XML_ABILITY_RANK = "rank";
        public const string XML_ABILITY_SLOT = "slot";

        public const string XML_STATS = "stats";
        public const string XML_STAT = "stat";
        public const string XML_STAT_TYPE = "type";
        public const string XML_STAT_VALUE = "value";
        public const string XML_STAT_RANK = "rank";
    }

    #endregion Constants

    #region Structs

    public struct ValidationResult
    {
        public bool valid;
        public string message;
    }

    #endregion Structs

    #region Enums

    public enum WeaponSlot
    {
        [Description("")]
        None = 0,

        [Description("eInvSlot_Unknown")]
        Unknown = 1,

        [Description("eInvSlot_PrimaryWeapon")]
        Primary = 2,

        [Description("eInvSlot_SecondaryWeapon")]
        Secondary = 3
    }

    public enum SoldierRank
    {
        [Description("Rookie")]
        Rookie = 0,

        [Description("Squaddie")]
        Squaddie = 1,

        [Description("Corporal")]
        Corporal = 2,

        [Description("Sergeant")]
        Sergeant = 3,

        [Description("Lieutenant")]
        Lieutenant = 4,

        [Description("Captain")]
        Captain = 5,

        [Description("Major")]
        Major = 6,

        [Description("Colonel")]
        Colonel = 7,

        [Description("Brigadier")]
        Brigadier = 8
    }

    public enum Stat
    {
        [Description("eStat_HP")]
        HP = 0,

        [Description("eStat_Offense")]
        Aim = 1,

        [Description("eStat_Strength")]
        Strength = 2,

        [Description("eStat_Hacking")]
        Hacking = 3,

        [Description("eStat_PsiOffense")]
        Psi = 4
    }

    #endregion Enums
}
