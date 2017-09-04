using Newtonsoft.Json;
using RestSharp;
namespace DestinySharp
{
    public partial class BungieClient
    {

        ///<summary>
        ///Loads a bungienet user by membership id.
        ///</summary>
        /// <param name="id">The requested Bungie.net membership id.</param>
        public dynamic GetBungieNetUserById(int id)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/User/GetBungieNetUserById/{id}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("id", id);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Loads aliases of a bungienet membership id.
        ///</summary>
        /// <param name="id">The requested Bungie.net membership id.</param>
        public dynamic GetUserAliases(int id)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/User/GetUserAliases/{id}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("id", id);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns a list of possible users based on the search string
        ///</summary>
        /// <param name="q">The search string.</param>
        public dynamic SearchUsers(string q)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/User/SearchUsers/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("q", q);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns a list of all available user themes.
        ///</summary>
        public dynamic GetAvailableThemes()
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/User/GetAvailableThemes/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns a list of accounts associated with the supplied membership ID and membership type. This will include all linked accounts (even when hidden) if supplied credentials permit it.
        ///</summary>
        /// <param name="membershipId">The membership ID of the target user.</param>
        /// <param name="membershipType">Type of the supplied membership ID.</param>
        public dynamic GetMembershipDataById(int membershipId, BungieMembershipType membershipType)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/User/GetMembershipsById/{membershipId}/{membershipType}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("membershipId", membershipId);
            request.AddParameter("membershipType", membershipType);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns a list of accounts associated with signed in user. This is useful for OAuth implementations that do not give you access to the token response.
        ///</summary>
        public dynamic GetMembershipDataForCurrentUser()
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/User/GetMembershipsForCurrentUser/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns a user's linked Partnerships.
        ///</summary>
        /// <param name="membershipId">The ID of the member for whom partnerships should be returned.</param>
        public dynamic GetPartnerships(int membershipId)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/User/{membershipId}/Partnerships/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("membershipId", membershipId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }

    }
}