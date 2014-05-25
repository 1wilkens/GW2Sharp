using MrFloya.GW2Sharp.Models;
using MrFloya.GW2Sharp.Tools;
using RestSharp;
using System.Linq;
using System.Collections.Generic;

namespace MrFloya.GW2Sharp
{
    public class GW2API
    {
        private API _api;

        private GW2API(APIConfiguration config)
        {
            _api = API.GetInstance(config);
        }

        public static GW2API Create(APIVersion version = APIVersion.V1, APILanguage language = APILanguage.EN)
        {
            return new GW2API(new APIConfiguration() { Version = version, Language = language });
        }

        public List<Continent> GetContinents()
        {
            return _api.CallAPI<Dictionary<string, Dictionary<int, Continent>>>(Constants.API_ENDPOINTS.Single(
                ep => ep.Name == APIEndpointName.Continents), null)
                // "continents:"
                .First().Value
                // "1", "2"
                .Values.ToList();
        }
    }
}