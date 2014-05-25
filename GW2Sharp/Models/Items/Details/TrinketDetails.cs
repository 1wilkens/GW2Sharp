using System.Collections.Generic;

namespace MrFloya.GW2Sharp.Models.Items.Details
{
    public class TrinketDetails
    {
        /// <summary>
        /// The TrinketItem's type
        /// </summary>
        public TrinketType Type { get; set; }
        /// <summary>
        /// The TrinketItem's InfusionSlots (if any)
        /// </summary>
        public List<InfusionSlot> InfusionSlots { get; set; }
        /// <summary>
        /// The TrinketItem's InfixUpgrade (if any)
        /// </summary>
        public InfixUpgrade InfixUpgrade { get; set; }
        /// <summary>
        /// The TrinketItem's SuffixID describing its effect
        /// </summary>
        public int SuffixItemID { get; set; }
    }

    public enum TrinketType
    {
        Accessory = 0,
        Amulet    = 1,
        Ring      = 2
    }
}