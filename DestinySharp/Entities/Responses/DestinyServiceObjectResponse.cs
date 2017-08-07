using DestinySharp.Core.Entities;
using System.Collections.Generic;

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
        public Dictionary<string, Activity> activities { get; set; }
        public Dictionary<string, Destination> destinations { get; set; }
        public Dictionary<string, Place> places { get; set; }
        public Dictionary<string, ActivityType> activityTypes { get; set; }
        public Dictionary<string, InventoryItem> items { get; set; }
        public Dictionary<string, InventoryBucket> buckets { get; set; }
        public Dictionary<string, Stat> stats { get; set; }
        public Dictionary<string, SandboxPerk> perks { get; set; }
        public Dictionary<string, TalentGrid> talentGrids { get; set; }
        public Dictionary<string, StatGroup> statGroups { get; set; }
        public Dictionary<string, Progression> progressionMappings { get; set; }
        public Dictionary<string, ItemCategory> itemCategories { get; set; }
        public Dictionary<string, RewardSource> sources { get; set; }
        public Dictionary<string, Objective> objectives { get; set; }
        public Dictionary<string, Progression> progressions { get; set; }
        public Dictionary<string, DestinyDamageType> damageTypes { get; set; }
        public Dictionary<string, object> materialRequirements { get; set; }
        public Dictionary<string, object> unlockValues { get; set; }
        public Dictionary<string, object> vendorDetails { get; set; }
        public Dictionary<string, object> locations { get; set; }
        public Dictionary<string, Faction> factions { get; set; }
        public Dictionary<string, object> events { get; set; }
        public Dictionary<string, VendorCategories> vendorCategories { get; set; }
        public Dictionary<string, VendorSummary> vendorSummaries { get; set; }
        public Dictionary<string, object> books { get; set; }
        public Dictionary<string, RecordBook> recordBooks { get; set; }
        public Dictionary<string, ActivityBundle> activityBundles { get; set; }
        public Dictionary<string, RecordBookRecord> records { get; set; }
    }
  
}
