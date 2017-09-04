using Newtonsoft.Json;
using RestSharp;
namespace DestinySharp
{
    public partial class BungieClient
    {

        ///<summary>
        ///Returns trending items for Bungie.net, collapsed into the first page of items per category.  For pagination within a category, call GetTrendingCategory.
        ///</summary>
        public dynamic GetTrendingCategories()
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Trending/Categories/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns paginated lists of trending items for a category.
        ///</summary>
        /// <param name="categoryId">The ID of the category for whom you want additional results.</param>
        /// <param name="pageNumber">The page # of results to return.</param>
        public dynamic GetTrendingCategory(string categoryId, int pageNumber)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Trending/Categories/{categoryId}/{pageNumber}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("categoryId", categoryId);
            request.AddParameter("pageNumber", pageNumber);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns the detailed results for a specific trending entry.  Note that trending entries are uniquely identified by a combination of *both* the TrendingEntryType *and* the identifier: the identifier alone is not guaranteed to be globally unique.
        ///</summary>
        /// <param name="identifier">The identifier for the entity to be returned.</param>
        /// <param name="trendingEntryType">The type of entity to be returned.</param>
        public dynamic GetTrendingEntryDetail(string identifier, Trending.TrendingEntryType trendingEntryType)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Trending/Details/{trendingEntryType}/{identifier}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("identifier", identifier);
            request.AddParameter("trendingEntryType", trendingEntryType);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }

    }
}