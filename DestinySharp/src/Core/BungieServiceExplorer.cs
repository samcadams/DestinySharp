using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinySharp.Core
{
    /// <summary>
    /// Main service explorer for the Destiny portion of the Bungie API
    /// </summary>
    public class DestinyServiceExplorer
    {
        RestClient _client = new RestClient("http://www.bungie.net/Platform/Destiny");
        string apikey { get; set; }

        /// <summary>
        /// Get hashed character summary by name.
        /// </summary>
        /// <param name="name">Gamertag/PSN Name</param>
        /// <param name="type">Enum of which console.</param>
        /// <returns></returns>
        public CharacterSummaryData GetCharacterSummary(string name, MembershipType type)
        {
            RestRequest request = new RestRequest($"/{(int)type}/Account/{GetMembershipId(name, type)}/Summary/");
            request.AddHeader("X-API-KEY", apikey);

            IRestResponse response = _client.Execute(request);

            var r = JsonConvert.DeserializeObject<DestinyServiceObjectResponse<CharacterSummaryData>>(response.Content);

            return r.Response.data;
        }

        /// <summary>
        /// Directly query the destiny manifest. Might not be able to cast to any object. Use carefully
        /// </summary>
        /// <typeparam name="T">Type of object you are recieving</typeparam>
        /// <param name="hash">Ulong hash code of object you desire more info about</param>
        /// <param name="type">DestinyDefinitionType of what the hash is. If it isn't obvious, try InventoryItem first.</param>
        /// <returns></returns>
        public T QueryManifest<T> (ulong hash, DestinyDefinitionType type)
        {
            RestRequest request = new RestRequest($"/Manifest/{type}/{hash}/");
            request.AddHeader("X-API-KEY", apikey);
            IRestResponse<DestinyServiceObjectResponse<T>> response = _client.Execute<DestinyServiceObjectResponse<T>>(request);

            return response.Data.Response.data;
        }

        public string QueryManifestTest(ulong hash, DestinyDefinitionType type)
        {
            RestRequest request = new RestRequest($"/Manifest/{type}/{hash}/");
            request.AddHeader("X-API-KEY", apikey);
            IRestResponse<DestinyServiceResponse> response = _client.Execute<DestinyServiceResponse>(request);

            return response.Content;
        }

        /// <summary>
        /// Internal method used to grab the Membership id via name and console.
        /// </summary>
        /// <param name="name">Gamertag/PSN name</param>
        /// <param name="type">Enum of console</param>
        /// <returns></returns>
        internal string GetMembershipId(string name, MembershipType type)
        {
            RestRequest request = new RestRequest($"/{(int)type}/Stats/GetMembershipIdByDisplayName/{name}/");
            request.AddHeader("X-API-KEY", apikey);
            IRestResponse<DestinyServiceResponse> response = _client.Execute<DestinyServiceResponse>(request);

            return response.Data.Response;
        }

        public DestinyServiceExplorer(string apikey)
        {
            this.apikey = apikey;
        }
    }
}
