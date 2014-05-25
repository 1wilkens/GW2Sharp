using MrFloya.GW2Sharp.Models;
using MrFloya.GW2Sharp.Tools;
using System.Collections.Generic;
using System.Linq;

namespace MrFloya.GW2Sharp
{
    /// <summary>
    /// Main entry point of the library.
    /// Provides high-level, strongly typed access 
    /// to all available Endpoints.
    /// </summary>
    public class GW2API
    {
        private API _api;

        private GW2API(APIConfiguration config)
        {
            _api = API.GetInstance(config);
        }

        /// <summary>
        /// Create a new GW2API instance to execute requests from
        /// </summary>
        /// <param name="version">Sets which Version of the API should be queried. Default: V1</param>
        /// <param name="language">Sets which Language to use for the requests. Default: EN</param>
        /// <returns>The newly created instance</returns>
        public static GW2API Create(APIVersion version = APIVersion.V1, APILanguage language = APILanguage.EN)
        {
            return new GW2API(new APIConfiguration() { Version = version, Language = language });
        }

        /// <summary>
        /// Get all available Continents from the API
        /// Wiki: http://wiki.guildwars2.com/wiki/API:1/continents
        /// </summary>
        /// <returns>The List of Continents</returns>
        public List<Continent> GetContinents()
        {
            return _api.CallAPI<Dictionary<string, Dictionary<int, Continent>>>(Constants.API_ENDPOINTS.Single(
                // select Continents APIEndpoint
                ep => ep.Name == APIEndpointName.Continents), null)
                // filter out root element
                .First().Value
                // map values to List
                .Values.ToList();
        }
    }
}