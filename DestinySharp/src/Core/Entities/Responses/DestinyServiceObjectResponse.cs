using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinySharp.Core
{
    /// <summary>
    /// Object response contains special generic typing to properly create the "Response.data" object
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DestinyServiceObjectResponse<T>
    {
        public Response<T> Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public MessageData MessageData { get; set; }
    }
    public class MessageData
    {
        dynamic data { get; set; }
    }
    public class Response<T>
    {
        public T data { get; set; }
        /// <summary>
        /// Null if definitions bool on request is false
        /// </summary>
        public Definitions definitions { get; set; }
    }
    public class Definitions
    {
        public Dictionary<string, object> activities { get; set; }
        public Dictionary<string, object> destinations { get; set; }
        public Dictionary<string, object> places { get; set; }
        public Dictionary<string, object> activityTypes { get; set; }
        public Dictionary<string, object> items { get; set; }
        public Dictionary<string, object> buckets { get; set; }
        public Dictionary<string, object> stats { get; set; }
        public Dictionary<string, object> perks { get; set; }
        public Dictionary<string, object> talentGrids { get; set; }
        public Dictionary<string, object> statGroups { get; set; }
        public Dictionary<string, object> progressionMappings { get; set; }
        public Dictionary<string, object> itemCategories { get; set; }
        public Dictionary<string, object> sources { get; set; }
        public Dictionary<string, object> objectives { get; set; }
        public Dictionary<string, object> progressions { get; set; }
        public Dictionary<string, object> damageTypes { get; set; }
        public Dictionary<string, object> materialRequirements { get; set; }
        public Dictionary<string, object> unlockValues { get; set; }
        public Dictionary<string, object> vendorDetails { get; set; }
        public Dictionary<string, object> locations { get; set; }
        public Dictionary<string, object> factions { get; set; }
        public Dictionary<string, object> events { get; set; }
        public Dictionary<string, object> vendorCategories { get; set; }
        public Dictionary<string, object> vendorSummaries { get; set; }
        public Dictionary<string, object> books { get; set; }
        public Dictionary<string, object> activityBundles { get; set; }
    }

    public class DefinitionActivity {

    }
    public class DefinitionDestinations
    {

    }
    public class DefinitionPlaces
    {

    }
    public class DefinitionActivityTypes
    {

    }
    public class DefinitionItems
    {

    }
    public class DefinitionBuckets
    {

    }
}
