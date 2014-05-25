namespace MrFloya.GW2Sharp.Tools
{
    public class APIEndpoint
    {
        private string _url;

        public string Name { get; set; }
        public string URL
        {
            get { return _url + Constants.API_EXTENSION; }
            set { _url = value.TrimEnd(Constants.API_EXTENSION.ToCharArray()); }
        }

        public APIEndpoint(string name, string url)
        {
            Name = name;
            URL = url;
        }
    }
}