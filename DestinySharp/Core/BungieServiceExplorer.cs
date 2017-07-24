using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinySharp.Core
{
    public class DestinyServiceExplorer
    {
        RestClient _client = new RestClient("http://www.bungie.net/Platform/Destiny");
        string apikey { get; set; }

        public Data GetCharacterSummary(string name, MembershipType type)
        {
            RestRequest request = new RestRequest($"/{(int)type}/Account/{GetMembershipId(name, type)}/Summary/");
            request.AddHeader("X-API-KEY", apikey);

            IRestResponse response = _client.Execute(request);

            var r = JsonConvert.DeserializeObject<DestinyServiceObjectResponse>(response.Content);

            return r.Response.data;
        }

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
