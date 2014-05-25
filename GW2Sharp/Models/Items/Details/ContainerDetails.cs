namespace MrFloya.GW2Sharp.Models.Items.Details
{
    public class ContainerDetails
    {
        /// <summary>
        /// The ContainerItem's type
        /// </summary>
        public ContainerType Type { get; set; }
    }

    public enum ContainerType
    {
        Default = 0,
        GiftBox = 1
    }
}