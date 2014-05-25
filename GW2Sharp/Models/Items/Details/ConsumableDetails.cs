namespace MrFloya.GW2Sharp.Models.Items.Details
{
    public class ConsumableDetails
    {
        /// <summary>
        /// The Consumable's type (booze, food, unlock)
        /// </summary>
        public ConsumableType Type { get; set; }

        // Food subtype
        /// <summary>
        /// The FoodEffect's duration
        /// </summary>
        public int Duration_ms { get; set; }
        /// <summary>
        /// The FoodEffect's description
        /// </summary>
        public string Description { get; set; }

        // Unlock subtype
        /// <summary>
        /// The UnlockConsumable's type (BagSlot, BankTab, Dye)
        /// </summary>
        public UnlockType UnlockType { get; set; }
        /// <summary>
        /// The ID of the color that gets unlocked using the UnlockConsumable
        /// </summary>
        public int ColorID { get; set; }
        /// <summary>
        /// The ID of the recipe that gets unlocked using the UnlockConsumable
        /// </summary>
        public int RecipeID { get; set; }
    }

    public enum ConsumableType
    {
        AppearanceChange = 0,
        Booze            = 1,
        ContractNpc      = 2,
        Food             = 3,
        Generic          = 4,
        Halloween        = 5,
        Immediate        = 6,
        Transmutation    = 7,
        Unlock           = 8,
        Utility          = 9
    }

    public enum UnlockType
    {
        BagSlot         = 0,
        BankTab         = 1,
        CraftingRecipe  = 2,
        Dye             = 3
    }
}