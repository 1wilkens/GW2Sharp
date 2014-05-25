namespace MrFloya.GW2Sharp.Items.Details
{
    public class GatheringDetails
    {
        /// <summary>
        /// The GatheringItem's type
        /// </summary>
        public GatheringType Type { get; set; }
    }

    public enum GatheringType
    {
        Foraging = 0,
        Logging  = 1,
        Mining   = 2
    }
}