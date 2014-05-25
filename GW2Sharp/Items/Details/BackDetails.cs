using System.Collections.Generic;

namespace MrFloya.GW2Sharp.Items.Details
{
    public class BackDetails
    {
        /// <summary>
        /// The BackItem's InfusionSlots (if any)
        /// </summary>
        public List<InfusionSlot> InfusionSlots { get; set; }
        /// <summary>
        /// The BackItem's InfixUpgrade (if any)
        /// </summary>
        public InfixUpgrade InfixUpgrade { get; set; }
        /// <summary>
        /// The BackItem's SuffixID describing its effect
        /// </summary>
        public int SuffixItemID { get; set; }
    }
}