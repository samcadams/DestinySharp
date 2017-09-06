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
        public string GetTopicsPaged(Forum.ForumTopicsCategoryFiltersEnum categoryFilter, int group, string locales, int page, int pageSize, Forum.ForumTopicsQuickDateEnum quickDate, Forum.ForumTopicsSortEnum sort, string tagstring)
        {
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
            return response.Content;
        }


        ///<summary>
        ///Gets a listing of all topics marked as part of the core group.
        ///</summary>
        /// <param name="categoryFilter">The category filter.</param>
        /// <param name="locales">Comma seperated list of locales posts must match to return in the result list. Default 'en'</param>
        /// <param name="page">Zero base page</param>
        /// <param name="quickDate">The date filter.</param>
        /// <param name="sort">The sort mode.</param>
        public string GetCoreTopicsPaged(Forum.ForumTopicsCategoryFiltersEnum categoryFilter, string locales, int page, Forum.ForumTopicsQuickDateEnum quickDate, Forum.ForumTopicsSortEnum sort)
        {
            var request = new RestRequest($"/Forum/GetCoreTopicsPaged/{page}/{sort}/{quickDate}/{categoryFilter}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("categoryFilter", categoryFilter);
            request.AddParameter("locales", locales);
            request.AddParameter("page", page);
            request.AddParameter("quickDate", quickDate);
            request.AddParameter("sort", sort);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return response.Content;
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
        public string GetPostsThreadedPaged(bool getParentPost, int page, int pageSize, int parentPostId, int replySize, bool rootThreadMode, string showbanned, Forum.ForumPostSortEnum sortMode)
        {
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
            return response.Content;
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
        public string GetPostsThreadedPagedFromChild(int childPostId, int page, int pageSize, int replySize, bool rootThreadMode, string showbanned, Forum.ForumPostSortEnum sortMode)
        {
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
            return response.Content;
        }


        ///<summary>
        ///Returns the post specified and its immediate parent.
        ///</summary>
        /// <param name="childPostId"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        public string GetPostAndParent(int childPostId, string showbanned)
        {
            var request = new RestRequest($"/Forum/GetPostAndParent/{childPostId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("childPostId", childPostId);
            request.AddParameter("showbanned", showbanned);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return response.Content;
        }


        ///<summary>
        ///Returns the post specified and its immediate parent of posts that are awaiting approval.
        ///</summary>
        /// <param name="childPostId"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        public string GetPostAndParentAwaitingApproval(int childPostId, string showbanned)
        {
            var request = new RestRequest($"/Forum/GetPostAndParentAwaitingApproval/{childPostId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("childPostId", childPostId);
            request.AddParameter("showbanned", showbanned);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return response.Content;
        }


        ///<summary>
        ///Gets the post Id for the given content item's comments, if it exists.
        ///</summary>
        /// <param name="contentId"></param>
        public string GetTopicForContent(int contentId)
        {
            var request = new RestRequest($"/Forum/GetTopicForContent/{contentId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("contentId", contentId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return response.Content;
        }


        ///<summary>
        ///Gets tag suggestions based on partial text entry, matching them with other tags previously used in the forums.
        ///</summary>
        /// <param name="partialtag">The partial tag input to generate suggestions from.</param>
        public string GetForumTagSuggestions(string partialtag)
        {
            var request = new RestRequest($"/Forum/GetForumTagSuggestions/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("partialtag", partialtag);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return response.Content;
        }


        ///<summary>
        ///Gets the specified forum poll.
        ///</summary>
        /// <param name="topicId">The post id of the topic that has the poll.</param>
        public string GetPoll(int topicId)
        {
            var request = new RestRequest($"/Forum/Poll/{topicId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("topicId", topicId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return response.Content;
        }


        ///<summary>
        ///Allows a user to slot themselves into a recuritment thread fireteam slot. Returns the new state of the fireteam.
        ///</summary>
        /// <param name="topicId">The post id of the recruitment topic you wish to join.</param>
        public string JoinFireteamThread(int topicId)
        {
            var request = new RestRequest($"/Forum/Recruit/Join/{topicId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("topicId", topicId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return response.Content;
        }


        ///<summary>
        ///Allows a user to remove themselves from a recuritment thread fireteam slot. Returns the new state of the fireteam.
        ///</summary>
        /// <param name="topicId">The post id of the recruitment topic you wish to leave.</param>
        public string LeaveFireteamThread(int topicId)
        {
            var request = new RestRequest($"/Forum/Recruit/Leave/{topicId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("topicId", topicId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return response.Content;
        }


        ///<summary>
        ///Allows a recruitment thread owner to kick a join user from the fireteam. Returns the new state of the fireteam.
        ///</summary>
        /// <param name="targetMembershipId">The id of the user you wish to kick.</param>
        /// <param name="topicId">The post id of the recruitment topic you wish to join.</param>
        public string KickBanFireteamApplicant(int targetMembershipId, int topicId)
        {
            var request = new RestRequest($"/Forum/Recruit/KickBan/{topicId}/{targetMembershipId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("targetMembershipId", targetMembershipId);
            request.AddParameter("topicId", topicId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return response.Content;
        }


        ///<summary>
        ///Allows the owner of a fireteam thread to approve all joined members and start a private message conversation with them.
        ///</summary>
        /// <param name="topicId">The post id of the recruitment topic to approve.</param>
        public string ApproveFireteamThread(int topicId)
        {
            var request = new RestRequest($"/Forum/Recruit/Approve/{topicId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("topicId", topicId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return response.Content;
        }


        ///<summary>
        ///Allows the caller to get a list of to 25 recruitment thread summary information objects.
        ///</summary>
        public string GetRecruitmentThreadSummaries()
        {
            var request = new RestRequest($"/Forum/Recruit/Summaries/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return response.Content;
        }


    }
}