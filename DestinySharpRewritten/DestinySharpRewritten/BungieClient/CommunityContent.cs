using Newtonsoft.Json;
using RestSharp;
namespace DestinySharp
{
    public partial class BungieClient
    {


        ///<summary>
        ///Returns community content.
        ///</summary>
        /// <param name="mediaFilter">The type of media to get</param>
        /// <param name="page">Zero based page</param>
        /// <param name="sort">The sort mode.</param>
        public dynamic GetCommunityContent(Forum.ForumTopicsCategoryFiltersEnum mediaFilter, int page, Forum.CommunityContentSortMode sort)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/CommunityContent/Get/{sort}/{mediaFilter}/{page}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("mediaFilter", mediaFilter);
            request.AddParameter("page", page);
            request.AddParameter("sort", sort);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns info about community members who are live streaming.
        ///</summary>
        /// <param name="modeHash">The hash of the Activity Mode for which streams should be retrieved.  Don't pass it in or pass 0 to not filter by mode.</param>
        /// <param name="page">Zero based page.</param>
        /// <param name="partnershipType">The type of partnership for which the status should be returned.</param>
        /// <param name="sort">The sort mode.</param>
        /// <param name="streamLocale">The locale for streams you'd like to see.  Don't pass this to fall back on your BNet locale.  Pass 'ALL' to not filter by locale.</param>
        public dynamic GetCommunityLiveStatuses(int modeHash, int page, Partnerships.PartnershipType partnershipType, Community.CommunityStatusSort sort, string streamLocale)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/CommunityContent/Live/All/{partnershipType}/{sort}/{page}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("modeHash", modeHash);
            request.AddParameter("page", page);
            request.AddParameter("partnershipType", partnershipType);
            request.AddParameter("sort", sort);
            request.AddParameter("streamLocale", streamLocale);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns info about community members who are live streaming in your clans.
        ///</summary>
        /// <param name="page">Zero based page.</param>
        /// <param name="partnershipType">The type of partnership for which the status should be returned.</param>
        /// <param name="sort">The sort mode.</param>
        public dynamic GetCommunityLiveStatusesForClanmates(int page, Partnerships.PartnershipType partnershipType, Community.CommunityStatusSort sort)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/CommunityContent/Live/Clan/{partnershipType}/{sort}/{page}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("page", page);
            request.AddParameter("partnershipType", partnershipType);
            request.AddParameter("sort", sort);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns info about community members who are live streaming among your friends.
        ///</summary>
        /// <param name="page">Zero based page.</param>
        /// <param name="partnershipType">The type of partnership for which the status should be returned.</param>
        /// <param name="sort">The sort mode.</param>
        public dynamic GetCommunityLiveStatusesForFriends(int page, Partnerships.PartnershipType partnershipType, Community.CommunityStatusSort sort)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/CommunityContent/Live/Friends/{partnershipType}/{sort}/{page}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("page", page);
            request.AddParameter("partnershipType", partnershipType);
            request.AddParameter("sort", sort);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns info about Featured live streams.
        ///</summary>
        /// <param name="page">Zero based page.</param>
        /// <param name="partnershipType">The type of partnership for which the status should be returned.</param>
        /// <param name="sort">The sort mode.</param>
        /// <param name="streamLocale">The locale for streams you'd like to see.  Don't pass this to fall back on your BNet locale.  Pass 'ALL' to not filter by locale.</param>
        public dynamic GetFeaturedCommunityLiveStatuses(int page, Partnerships.PartnershipType partnershipType, Community.CommunityStatusSort sort, string streamLocale)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/CommunityContent/Live/Featured/{partnershipType}/{sort}/{page}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("page", page);
            request.AddParameter("partnershipType", partnershipType);
            request.AddParameter("sort", sort);
            request.AddParameter("streamLocale", streamLocale);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets the Live Streaming status of a particular Account and Membership Type.
        ///</summary>
        /// <param name="membershipId">The membershipId related to that type.</param>
        /// <param name="membershipType">The type of account for which info will be extracted.</param>
        /// <param name="partnershipType">The type of partnership for which info will be extracted.</param>
        public dynamic GetStreamingStatusForMember(int membershipId, BungieMembershipType membershipType, Partnerships.PartnershipType partnershipType)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/CommunityContent/Live/Users/{partnershipType}/{membershipType}/{membershipId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("membershipId", membershipId);
            request.AddParameter("membershipType", membershipType);
            request.AddParameter("partnershipType", partnershipType);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }

    }
}