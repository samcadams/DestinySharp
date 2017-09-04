using Newtonsoft.Json;
using RestSharp;
namespace DestinySharp
{
    public partial class BungieClient
    {

        ///<summary>
        ///Get topics from any forum.
        ///</summary>
        /// <param name="categoryFilter">A category filter</param>
        /// <param name="group">The group, if any.</param>
        /// <param name="locales">Comma seperated list of locales posts must match to return in the result list. Default 'en'</param>
        /// <param name="page">Zero paged page number</param>
        /// <param name="pageSize">Unused</param>
        /// <param name="quickDate">A date filter.</param>
        /// <param name="sort">The sort mode.</param>
        /// <param name="tagstring">The tags to search, if any.</param>
        public dynamic GetTopicsPaged(Forum.ForumTopicsCategoryFiltersEnum categoryFilter, int group, string locales, int page, int pageSize, Forum.ForumTopicsQuickDateEnum quickDate, Forum.ForumTopicsSortEnum sort, string tagstring)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/GetTopicsPaged/{page}/{pageSize}/{group}/{sort}/{quickDate}/{categoryFilter}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("categoryFilter", categoryFilter);
            request.AddParameter("group", group);
            request.AddParameter("locales", locales);
            request.AddParameter("page", page);
            request.AddParameter("pageSize", pageSize);
            request.AddParameter("quickDate", quickDate);
            request.AddParameter("sort", sort);
            request.AddParameter("tagstring", tagstring);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets a listing of all topics marked as part of the core group.
        ///</summary>
        /// <param name="categoryFilter">The category filter.</param>
        /// <param name="locales">Comma seperated list of locales posts must match to return in the result list. Default 'en'</param>
        /// <param name="page">Zero base page</param>
        /// <param name="quickDate">The date filter.</param>
        /// <param name="sort">The sort mode.</param>
        public dynamic GetCoreTopicsPaged(Forum.ForumTopicsCategoryFiltersEnum categoryFilter, string locales, int page, Forum.ForumTopicsQuickDateEnum quickDate, Forum.ForumTopicsSortEnum sort)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/GetCoreTopicsPaged/{page}/{sort}/{quickDate}/{categoryFilter}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("categoryFilter", categoryFilter);
            request.AddParameter("locales", locales);
            request.AddParameter("page", page);
            request.AddParameter("quickDate", quickDate);
            request.AddParameter("sort", sort);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns a thread of posts at the given parent, optionally returning replies to those posts as well as the original parent.
        ///</summary>
        /// <param name="getParentPost"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentPostId"></param>
        /// <param name="replySize"></param>
        /// <param name="rootThreadMode"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        /// <param name="sortMode"></param>
        public dynamic GetPostsThreadedPaged(bool getParentPost, int page, int pageSize, int parentPostId, int replySize, bool rootThreadMode, string showbanned, Forum.ForumPostSortEnum sortMode)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/GetPostsThreadedPaged/{parentPostId}/{page}/{pageSize}/{replySize}/{getParentPost}/{rootThreadMode}/{sortMode}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("getParentPost", getParentPost);
            request.AddParameter("page", page);
            request.AddParameter("pageSize", pageSize);
            request.AddParameter("parentPostId", parentPostId);
            request.AddParameter("replySize", replySize);
            request.AddParameter("rootThreadMode", rootThreadMode);
            request.AddParameter("showbanned", showbanned);
            request.AddParameter("sortMode", sortMode);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns a thread of posts starting at the topicId of the input childPostId, optionally returning replies to those posts as well as the original parent.
        ///</summary>
        /// <param name="childPostId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="replySize"></param>
        /// <param name="rootThreadMode"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        /// <param name="sortMode"></param>
        public dynamic GetPostsThreadedPagedFromChild(int childPostId, int page, int pageSize, int replySize, bool rootThreadMode, string showbanned, Forum.ForumPostSortEnum sortMode)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/GetPostsThreadedPagedFromChild/{childPostId}/{page}/{pageSize}/{replySize}/{rootThreadMode}/{sortMode}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("childPostId", childPostId);
            request.AddParameter("page", page);
            request.AddParameter("pageSize", pageSize);
            request.AddParameter("replySize", replySize);
            request.AddParameter("rootThreadMode", rootThreadMode);
            request.AddParameter("showbanned", showbanned);
            request.AddParameter("sortMode", sortMode);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns the post specified and its immediate parent.
        ///</summary>
        /// <param name="childPostId"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        public dynamic GetPostAndParent(int childPostId, string showbanned)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/GetPostAndParent/{childPostId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("childPostId", childPostId);
            request.AddParameter("showbanned", showbanned);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns the post specified and its immediate parent of posts that are awaiting approval.
        ///</summary>
        /// <param name="childPostId"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        public dynamic GetPostAndParentAwaitingApproval(int childPostId, string showbanned)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/GetPostAndParentAwaitingApproval/{childPostId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("childPostId", childPostId);
            request.AddParameter("showbanned", showbanned);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets the post Id for the given content item's comments, if it exists.
        ///</summary>
        /// <param name="contentId"></param>
        public dynamic GetTopicForContent(int contentId)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/GetTopicForContent/{contentId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("contentId", contentId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets tag suggestions based on partial text entry, matching them with other tags previously used in the forums.
        ///</summary>
        /// <param name="partialtag">The partial tag input to generate suggestions from.</param>
        public dynamic GetForumTagSuggestions(string partialtag)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/GetForumTagSuggestions/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("partialtag", partialtag);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets the specified forum poll.
        ///</summary>
        /// <param name="topicId">The post id of the topic that has the poll.</param>
        public dynamic GetPoll(int topicId)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/Poll/{topicId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("topicId", topicId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Allows a user to slot themselves into a recuritment thread fireteam slot. Returns the new state of the fireteam.
        ///</summary>
        /// <param name="topicId">The post id of the recruitment topic you wish to join.</param>
        public dynamic JoinFireteamThread(int topicId)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/Recruit/Join/{topicId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("topicId", topicId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Allows a user to remove themselves from a recuritment thread fireteam slot. Returns the new state of the fireteam.
        ///</summary>
        /// <param name="topicId">The post id of the recruitment topic you wish to leave.</param>
        public dynamic LeaveFireteamThread(int topicId)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/Recruit/Leave/{topicId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("topicId", topicId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Allows a recruitment thread owner to kick a join user from the fireteam. Returns the new state of the fireteam.
        ///</summary>
        /// <param name="targetMembershipId">The id of the user you wish to kick.</param>
        /// <param name="topicId">The post id of the recruitment topic you wish to join.</param>
        public dynamic KickBanFireteamApplicant(int targetMembershipId, int topicId)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/Recruit/KickBan/{topicId}/{targetMembershipId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("targetMembershipId", targetMembershipId);
            request.AddParameter("topicId", topicId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Allows the owner of a fireteam thread to approve all joined members and start a private message conversation with them.
        ///</summary>
        /// <param name="topicId">The post id of the recruitment topic to approve.</param>
        public dynamic ApproveFireteamThread(int topicId)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/Recruit/Approve/{topicId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("topicId", topicId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Allows the caller to get a list of to 25 recruitment thread summary information objects.
        ///</summary>
        public dynamic GetRecruitmentThreadSummaries()
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Forum/Recruit/Summaries/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }

    }
}