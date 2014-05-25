using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrFloya.GW2Sharp.Models
{
    public class Continent
    {
        [JsonProperty(PropertyName="name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "continent_dims")]
        public int[] Dimensions { get; set; }
        [JsonProperty(PropertyName = "min_zoom")]
        public byte MinZoomLevel { get; set; }
        [JsonProperty(PropertyName = "max_zoom")]
		public byte MaxZoomLevel { get; set; }
        [JsonProperty(PropertyName = "floors")]
        public int[] Floors { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
