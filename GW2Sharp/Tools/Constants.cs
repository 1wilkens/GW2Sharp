using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MrFloya.GW2Sharp.Tools
{
    public static class Constants
    {
        public const string API_BASE_URL = "https://api.guildwars2.com";
        public const string API_EXTENSION = ".json";

        public static readonly IList<APIEndpoint> API_ENDPOINTS = new List<APIEndpoint>
            {
                // General
                new APIEndpoint(APIEndpointName.Build, "build"),
                new APIEndpoint(APIEndpointName.Colors, "colors"),
                new APIEndpoint(APIEndpointName.Files, "files"),

                // Events
                new APIEndpoint(APIEndpointName.EventNames, "event_names"),
                new APIEndpoint(APIEndpointName.EventList, "events"),
                new APIEndpoint(APIEndpointName.EventDetails, "event_details"),

                // Items
                new APIEndpoint(APIEndpointName.ItemList, "items"),
                new APIEndpoint(APIEndpointName.ItemDetails, "item_details"),
                new APIEndpoint(APIEndpointName.RecipeList, "recipes"),
                new APIEndpoint(APIEndpointName.RecipeDetails, "recipe_details"),

                // Maps
                new APIEndpoint(APIEndpointName.Continents, "/continents"),
                new APIEndpoint(APIEndpointName.MapList, "maps"),
                new APIEndpoint(APIEndpointName.MapNames, "map_names"),
                new APIEndpoint(APIEndpointName.MapDetails, "map_floor"),

                // WvW
                new APIEndpoint(APIEndpointName.WvWMatches, "wvw/matches"),
                new APIEndpoint(APIEndpointName.WvWMatchDetails, "wvw/match_details"),
                new APIEndpoint(APIEndpointName.WvWObjectiveNames, "wvw/objective_names")

            }.AsReadOnly();
    }
}