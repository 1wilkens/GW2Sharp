namespace MrFloya.GW2Sharp.Models.Items.Details
{
    public class ArmorDetails
    {
        /// <summary>
        /// The ArmorItem's type (Boots, Gloves, Leggings etc.)
        /// </summary>
        public ArmorType Type { get; set; }
        /// <summary>
        /// The ArmorItem's WeightClass (Clothing, Light, Medium, Heavy)
        /// </summary>
        public WeightClass WeigthClass { get; set; }
        /// <summary>
        /// The ArmorItem's defense value
        /// </summary>
        public int Defense { get; set; }
    }

    public enum ArmorType
    {
        Boots       = 0,
        Coat        = 1,
        Gloves      = 2,
        Helm        = 3,
        HelmAquatic = 4,
        Leggings    = 5,
        Shoulders   = 6
    }

    public enum WeightClass
    {
        Clothing = 0,
        Heavy    = 1,
        Light    = 2,
        Medium   = 3
    }
}