using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrFloya.GW2Sharp.Models.Items.Details
{
    public class UpgradeComponentDetails
    {
        /// <summary>
        /// The UpgradeComponentItem's type
        /// </summary>
        public UpgradeComponentType Type { get; set; }
        /// <summary>
        /// The Flags deciding on which ItemTypes the UpgradeComponentItem is applicable
        /// </summary>
        public UpgradeComponentFlags Flags { get; set; }
        /// <summary>
        /// The UpgradeComponentItem's InfusionType
        /// </summary>
        public InfusionType InfusionUpgradeFlags { get; set; }    //ToDo: |17.09.13| Find out why exactly this is used here 
        /// <summary>
        /// The (up to 6) bonuses granted from equipping the Rune (Runes only)
        /// </summary>
        public List<string> Bonuses { get; set; }
        /// <summary>
        /// The InfixUpgrade granted from equipping the UpgradeComponentItem
        /// </summary>
        public InfixUpgrade InfixUpgrade { get; set; }
        /// <summary>
        /// The Suffix granted from equipping the UpgradeComponentItem
        /// </summary>
        public string Suffix { get; set; }
    }

    public enum UpgradeComponentType
    {
        Default = 0,
        Gem     = 1,
        Rune    = 2,
        Sigill  = 3
    }

    public enum UpgradeComponentFlags
    {
        // Armor flags
        HeavyArmor  = 0,
        LightArmor  = 1,
        MediumArmor = 2,
        // Trinket
        Trinket     = 3,
        // Weapon flags
        Axe         = 4,
        LongBow     = 5,
        ShortBow    = 6,
        Dagger      = 7,
        Focus       = 8,
        Greatsword  = 9,
        Hammer      = 10,
        Harpoon     = 11,
        Mace        = 12,
        Pistol      = 13,
        Rifle       = 14,
        Scepter     = 15,
        Shield      = 16,
        Speargun    = 17,
        Staff       = 18,
        Sword       = 19,
        Torch       = 20,
        Trident     = 21,
        Warhorn     = 22
    }
}