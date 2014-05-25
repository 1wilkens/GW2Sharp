using System.Collections.Generic;

namespace MrFloya.GW2Sharp.Items.Details
{
    public class InfusionSlot
    {
        /// <summary>
        /// The InfusionSlot's type (Defense, Offensive, Utility)
        /// </summary>
        public List<InfusionType> Flags { get; set; }
        /// <summary>
        /// Not yet used..
        /// </summary>
        public string Item { get; set; }              //ToDo: |17.09.13| Currenty null but might change in new API version
    }

    public enum InfusionType
    {
        Defense = 0,
        Offense = 1,
        Utility = 2
    }
}