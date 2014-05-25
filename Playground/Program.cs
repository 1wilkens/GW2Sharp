using System;
using System.Collections.Generic;
using RestSharp;
using RestSharp.Deserializers;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace MrFloya.GW2Sharp.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = GW2API.Create();

            var continents = api.GetContinents();
       
            Console.ReadKey();
        }
    }

    public class Continent
    {
        public string Name { get; set; }
        [JsonProperty(PropertyName="continent_dims")]
        public int[] Dimensions { get; set; }
        public byte MinZoomLevel { get; set; }
        public byte MaxZoomLevel { get; set; }
        public int[] Floors { get; set; }
    }

    public class Test
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
    }

    public class Derived : Test
    {
        public string Type { get; set; }
    }
}