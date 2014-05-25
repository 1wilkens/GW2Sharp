namespace MrFloya.GW2Sharp.Items.Details
{
    public class BagDetails
    {
        /// <summary>
        /// A value indicating wether the Bag can be sorted or sold
        /// </summary>
        public bool NoSellOrSort { get; set; }
        /// <summary>
        /// The Bag's size (how many Items can be stored)
        /// </summary>
        public int Size { get; set; }
    }
}