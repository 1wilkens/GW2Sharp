using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrFloya.GW2Sharp.Items.Details
{
    public class WeaponDetails
    {
        /// <summary>
        /// The WeaponItem's type (axe, focus, spear etc.)
        /// </summary>
        public WeaponType Type { get; set; }
        /// <summary>
        /// The WeaponItem's DamageType (fire, ice, lightning, physical)
        /// </summary>
        public DamageType DamageType { get; set; }
        /// <summary>
        /// The WeaponItem's MinPower value (if any)
        /// </summary>
        public int MinPower { get; set; }
        /// <summary>
        /// The WeaponItem's MaxPower value (if any)
        /// </summary>
        public int MaxPower { get; set; }
        /// <summary>
        /// The WeaponItem's Defense value (if any)
        /// </summary>
        public int Defense { get; set; }
        /// <summary>
        /// The WeaponItem's InfusionSlots (if any)
        /// </summary>
        public List<InfusionSlot> InfusionSlots { get; set; }
        /// <summary>
        /// The WeaponItem's InfixUpgrade (if any)
        /// </summary>
        public InfixUpgrade InfixUpgrade { get; set; }
        /// <summary>
        /// The WeaponItem's SuffixID
        /// </summary>
        public int SuffixItemID { get; set; }
    }

    public enum WeaponType
    {
        Axe          = 0,
        Dagger       = 1,
        Focus        = 2,
        Greatsword   = 3,
        Hammer       = 4,
        Harpoon      = 5,
        LargeBundle  = 6,
        LongBow      = 7,
        Mace         = 8,
        Pistol       = 9,
        Rifle        = 10,
        Scepter      = 11,
        Shield       = 12,
        ShortBow     = 13,
        Speargun     = 14,
        Staff        = 15,
        Sword        = 16,
        Torch        = 17,
        Toy          = 18,
        Trident      = 19,
        TwoHandedToy = 20,
        Warhorn      = 21
    }

    public enum DamageType
    {
        Fire      = 0,
        Ice       = 1,
        Lightning = 2,
        Physical  = 3
    }
}