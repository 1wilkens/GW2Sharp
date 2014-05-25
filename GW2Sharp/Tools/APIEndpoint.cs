namespace MrFloya.GW2Sharp.Tools
{
    public class APIEndpoint
    {
        private string _url;

        public APIEndpointName Name { get; set; }
        public string URL
        {
            get { return _url + Constants.API_EXTENSION; }
            set { _url = value; }
        }

        public APIEndpoint(APIEndpointName name, string url)
        {
            Name = name;
            URL = url;
        }
    }

    public enum APIEndpointName
    {
        //General
        Build               = 0,
        Colors              = 1,
        Files               = 2,

        //Events
        EventNames          = 3,
        EventList           = 4,
        EventDetails        = 5,

        //Items
        ItemList            = 6,
        ItemDetails         = 7,
        RecipeList          = 8,
        RecipeDetails       = 9,

        //Maps
        Continents          = 10,
        MapList             = 11,
        MapNames            = 12,
        MapDetails          = 13,

        // WvWvW
        WvWMatches          = 14,
        WvWMatchDetails     = 15,
        WvWObjectiveNames   = 16,

    }
}