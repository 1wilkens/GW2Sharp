using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrFloya.GW2Sharp.Models.Items
{
    public abstract class BaseItem
    {
        /// <summary>
        /// The Item's ID
        /// </summary>
        public int ItemID { get; set; }
        /// <summary>
        /// The Item's Name (localized in the API's selected language)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Item's Description text (localized in the API's selected language)
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The Item's Type (Weapon, Armor, Consumable etc.).
        /// This field decides which subclass of BaseItem an Item get deserialized into
        /// </summary>
        public ItemType Type { get; set; }
        /// <summary>
        /// The characterlevel required to use this Item
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// The Item's rarity (Fine, Masterwork, Rare etc.)
        /// </summary>
        public ItemRarity Rarity { get; set; }
        /// <summary>
        /// The value of the Item when vendored (in copper)
        /// </summary>
        public int VendorValue { get; set; }
        /// <summary>
        /// The Item's icon-file ID. 
        /// Gets used to download its icon from the API's render service
        /// </summary>
        public string IconFileID { get; set; }
        /// <summary>
        /// The Item's icon-file signature. 
        /// Gets used to download its icon from the API's render service
        /// </summary>
        public string IconFileSignature { get; set; }
        /// <summary>
        /// A list of GameTypes where the Item can be used in
        /// </summary>
        public List<GameType> GameTypes { get; set; }
        /// <summary>
        /// A list of additional Flags applicable to the Item
        /// </summary>
        public List<ItemFlag> Flags { get; set; }
        /// <summary>
        /// A list of additional restrictions applicable to the Item.
        /// Currently not used effectively
        /// </summary>
        public List<string> Restrictions { get; set; }
    }
}