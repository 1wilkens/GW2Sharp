using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrFloya.GW2Sharp.Models.Items
{
    public class BackItem : BaseItem
    {
        /// <summary>
        /// The BackItem's back specific properties
        /// </summary>
        public Details.BackDetails Back { get; set; }
    }
}