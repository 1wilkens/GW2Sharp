using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;
using RestSharp;

namespace MrFloya.GW2Sharp.Tools
{
    internal sealed class API
    {
        // Singleton related fields
        private static API _api = null;
        private static readonly object _padlock = new object();

        // Actual fields
        private APIConfiguration _config = null;
        private RestClient _client = null;

        private API(APIConfiguration config)
        {
            _config = config;
            _client = new RestClient(Constants.API_BASE_URL + "/" + Enum.GetName(typeof(APIVersion), _config.Version).ToLower());
        }

        /// <summary>
        /// Get JSON from an APIEndpoint
        /// </summary>
        /// <param name="endpoint">The APIEndpoint to get the JSON from</param>
        /// <param name="parameters">The (optional) parameters to apply to the GET request</param>
        /// <exception cref="ArgumentNullException">Gets thrown if endpoint is null</exception>
        /// <returns>A string containing the received JSON</returns>
        internal string GetJson(APIEndpoint endpoint, IEnumerable<KeyValuePair<string, object>> parameters)
        {
            if (endpoint == null)
                throw new ArgumentNullException("endpoint");

            var request = new RestRequest(endpoint.URL);
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    //ToDo: |13.09.13| Validate and add language from APIConfiguration where appropiate
                    request.AddParameter(parameter.Key, parameter.Value);
                }
            }
            return _client.Execute(request).Content.ToString();
        }

        internal T CallAPI<T>(APIEndpoint endpoint, IEnumerable<KeyValuePair<string, object>> parameters)
        {
            var json = GetJson(endpoint, parameters);
            return JsonConvert.DeserializeObject<T>(json);
        }

        #region Singleton related methods
        /// <summary>
        /// Checks the existance of a current instance of API
        /// </summary>
        /// <returns>A value wether an instance exists</returns>
        internal static bool HasInstance()
        {
            lock (_padlock)
                return _api != null;
        }

        /// <summary>
        /// Gets the current instance of API. 
        /// </summary>
        /// <exception cref="Exception">If no current instance exists an Exception will be thrown.</exception>
        /// <returns>The current API instance</returns>
        internal static API GetInstance()
        {
            if (!HasInstance())
                throw new Exception("No existing instance of API. Must create one first via GetInstance(APIConfiguration)!");

            lock (_padlock)
                return _api;
        }

        /// <summary>
        /// Gets an instance of API with the given APIConfiguration.
        /// A new API instance gets constructed if..
        ///     - no instance existes previously
        ///     - or the current API's configuration does not match the given one
        /// </summary>
        /// <param name="config">The APIConfiguration of the API to get</param>
        /// <returns>A valid API instance with the given configuration</returns>
        internal static API GetInstance(APIConfiguration config)
        {
            if (config == null)
                throw new ArgumentNullException("config");

            lock (_padlock)
            {
                if (_api == null || _api._config != config)
                    _api = new API(config);
                return _api;
            }
        }
        #endregion
    }
}