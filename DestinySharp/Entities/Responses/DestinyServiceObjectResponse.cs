using DestinySharp.Core.Entities;
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
        public Dictionary<string, Activity> activities { get; set; }
        public Dictionary<string, Destination> destinations { get; set; }
        public Dictionary<string, Place> places { get; set; }
        public Dictionary<string, ActivityType> activityTypes { get; set; }
        public Dictionary<string, InventoryItem> items { get; set; }
        public Dictionary<string, InventoryBucket> buckets { get; set; }
        public Dictionary<string, DefinitionStats> stats { get; set; }
        public Dictionary<string, DefinitionPerks> perks { get; set; }
        public Dictionary<string, DefinitionTalentGrids> talentGrids { get; set; }
        public Dictionary<string, DefinitionStatGroups> statGroups { get; set; }
        public Dictionary<string, object> progressionMappings { get; set; }
        public Dictionary<string, DefinitionItemCategories> itemCategories { get; set; }
        public Dictionary<string, DefinitionSources> sources { get; set; }
        public Dictionary<string, DefinitionObjectives> objectives { get; set; }
        public Dictionary<string, DefinitionProgressions> progressions { get; set; }
        public Dictionary<string, DefinitionDamageTypes> damageTypes { get; set; }
        public Dictionary<string, object> materialRequirements { get; set; }
        public Dictionary<string, DefinitionUnlockValues> unlockValues { get; set; }
        public Dictionary<string, object> vendorDetails { get; set; }
        public Dictionary<string, object> locations { get; set; }
        public Dictionary<string, object> factions { get; set; }
        public Dictionary<string, object> events { get; set; }
        public Dictionary<string, object> vendorCategories { get; set; }
        public Dictionary<string, object> vendorSummaries { get; set; }
        public Dictionary<string, object> books { get; set; }
        public Dictionary<string, DefinitionRecordBooks> recordBooks { get; set; }
        public Dictionary<string, object> activityBundles { get; set; }
        public Dictionary<string, DefinitionRecords> records { get; set; }
    }
  
}
