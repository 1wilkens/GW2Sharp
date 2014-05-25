namespace MrFloya.GW2Sharp.Items.Details
{
    public class ToolDetails
    {
        /// <summary>
        /// The ToolItem's type (only Salvage @the moment) ToDo: |17.09.13| Might add more in a future API update
        /// </summary>
        public ToolType Type { get; set; }
        /// <summary>
        /// The ToolItem's remaining charges
        /// </summary>
        public int Charges { get; set; }
    }

    public enum ToolType
    {
        Salvage = 0
    }
}