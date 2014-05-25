using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MrFloya.GW2Sharp.Tools
{
    public static class Constants
    {
        public const string API_BASE_URL = "https://api.guildwars2.com";
        public const string API_EXTENSION = ".json";

        public static readonly ReadOnlyCollection<APIEndpoint> API_ENDPOINTS = new List<APIEndpoint>
            {
                // General
                new APIEndpoint("Build", "build"),
                new APIEndpoint("Colors", "colors"),
                new APIEndpoint("Files", "files"),

                // Events
                new APIEndpoint("EventNames", "event_names"),
                new APIEndpoint("EventList", "events"),
                new APIEndpoint("EventDetails", "event_details"),

                // Items
                new APIEndpoint("ItemList", "items"),
                new APIEndpoint("ItemDetails", "item_details"),
                new APIEndpoint("RecipeList", "recipes"),
                new APIEndpoint("RecipeDetails", "recipe_details"),

                // Maps
                new APIEndpoint("Continents", "continents"),
                new APIEndpoint("MapList", "maps"),
                new APIEndpoint("MapNames", "map_names"),
                new APIEndpoint("MapDetails", "map_floor"),

                // WvW
                new APIEndpoint("WvWMatches", "wvw/matches"),
                new APIEndpoint("WvWMatchDetails", "wvw/match_details"),
                new APIEndpoint("WvWObjectiveNames", "wvw/objective_names")

            }.AsReadOnly();
    }
}