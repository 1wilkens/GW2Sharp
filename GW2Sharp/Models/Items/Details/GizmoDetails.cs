namespace MrFloya.GW2Sharp.Models.Items.Details
{
    public class GizmoDetails
    {
        /// <summary>
        /// The GizmoItem's type
        /// </summary>
        public GizmoType Type { get; set; }
    }

    public enum GizmoType
    {
        Default             = 0,
        RentableContractNpc = 1,
        UnlimitedConsumable = 2
    }
}