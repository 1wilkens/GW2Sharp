using System;
using System.Collections.Generic;
using RestSharp;
using RestSharp.Deserializers;
using System.IO;
using Newtonsoft.Json.Linq;

namespace MrFloya.GW2Sharp.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://api.guildwars2.com/v1/");

            var request = new RestRequest("item_details.json", Method.GET);
            request.AddParameter("item_id", 25845);
            request.AddParameter("lang", "de");

            var response = client.Execute(request).Content;

            Console.ReadKey();
        }
    }

    public class WorldEntry
    {
        public string ID { get; internal set; }
        public string Name { get; internal set; }
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