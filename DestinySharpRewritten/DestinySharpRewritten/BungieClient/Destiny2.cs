using Newtonsoft.Json;
using RestSharp;
namespace DestinySharp
{
    public partial class BungieClient
    {

        ///<summary>
        ///Returns the current version of the manifest as a json object.
        ///</summary>
        public dynamic GetDestinyManifest()
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Manifest/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns a list of Destiny memberships given a full Gamertag or PSN ID.
        ///</summary>
        /// <param name="displayName">The full gamertag or PSN id of the player. Spaces and case are ignored.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type, or All.</param>
        public dynamic SearchDestinyPlayer(string displayName, BungieMembershipType membershipType)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/SearchDestinyPlayer/{membershipType}/{displayName}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("displayName", displayName);
            request.AddParameter("membershipType", membershipType);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns Destiny Profile information for the supplied membership.
        ///</summary>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values).  See the DestinyComponentType enum for valid components to request.  You must request at least one component to receive results.</param>
        /// <param name="destinyMembershipId">Destiny membership ID.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        public dynamic GetProfile(object[] components, int destinyMembershipId, BungieMembershipType membershipType)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/{membershipType}/Profile/{destinyMembershipId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("components", components);
            request.AddParameter("destinyMembershipId", destinyMembershipId);
            request.AddParameter("membershipType", membershipType);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns character information for the supplied character.
        ///</summary>
        /// <param name="characterId">ID of the character.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values).  See the DestinyComponentType enum for valid components to request.  You must request at least one component to receive results.</param>
        /// <param name="destinyMembershipId">Destiny membership ID.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        public dynamic GetCharacter(int characterId, object[] components, int destinyMembershipId, BungieMembershipType membershipType)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("characterId", characterId);
            request.AddParameter("components", components);
            request.AddParameter("destinyMembershipId", destinyMembershipId);
            request.AddParameter("membershipType", membershipType);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Returns information on the weekly clan rewards and if the clan has earned them or not. Note that this will always report rewards as not redeemed.
        ///</summary>
        /// <param name="groupId">A valid group id of clan.</param>
        public dynamic GetClanWeeklyRewardState(int groupId)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Clan/{groupId}/WeeklyRewardState/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("groupId", groupId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Retrieve the details of an instanced Destiny Item.  An instanced Destiny item is one with an ItemInstanceId.  Non-instanced items, such as materials, have no useful instance-specific details and thus are not queryable here.
        ///</summary>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values).  See the DestinyComponentType enum for valid components to request.  You must request at least one component to receive results.</param>
        /// <param name="destinyMembershipId">The membership ID of the destiny profile.</param>
        /// <param name="itemInstanceId">The Instance ID of the destiny item.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        public dynamic GetItem(object[] components, int destinyMembershipId, int itemInstanceId, BungieMembershipType membershipType)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Item/{itemInstanceId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("components", components);
            request.AddParameter("destinyMembershipId", destinyMembershipId);
            request.AddParameter("itemInstanceId", itemInstanceId);
            request.AddParameter("membershipType", membershipType);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Get currently available vendors.  PREVIEW: This service is not yet active, but we are returning the planned schema of the endpoint for review, comment, and preparation for its eventual implementation.
        ///</summary>
        /// <param name="characterId">The Destiny Character ID of the character for whom we're getting vendor info.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values).  See the DestinyComponentType enum for valid components to request.  You must request at least one component to receive results.</param>
        /// <param name="destinyMembershipId">Destiny membership ID of another user. You may be denied.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        public dynamic GetVendors(int characterId, object[] components, int destinyMembershipId, BungieMembershipType membershipType)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("characterId", characterId);
            request.AddParameter("components", components);
            request.AddParameter("destinyMembershipId", destinyMembershipId);
            request.AddParameter("membershipType", membershipType);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Get the details of a specific Vendor.  PREVIEW: This service is not yet active, but we are returning the planned schema of the endpoint for review, comment, and preparation for its eventual implementation.
        ///</summary>
        /// <param name="characterId">The Destiny Character ID of the character for whom we're getting vendor info.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values).  See the DestinyComponentType enum for valid components to request.  You must request at least one component to receive results.</param>
        /// <param name="destinyMembershipId">Destiny membership ID of another user. You may be denied.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="vendorHash">The Hash identifier of the Vendor to be returned.</param>
        public dynamic GetVendor(int characterId, object[] components, int destinyMembershipId, BungieMembershipType membershipType, int vendorHash)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/{vendorHash}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("characterId", characterId);
            request.AddParameter("components", components);
            request.AddParameter("destinyMembershipId", destinyMembershipId);
            request.AddParameter("membershipType", membershipType);
            request.AddParameter("vendorHash", vendorHash);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Transfer an item to/from your vault.  You must have a valid Destiny account.  You must also pass BOTH a reference AND an instance ID if it's an instanced item.  itshappening.gif
        ///</summary>
        public dynamic TransferItem()
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Actions/Items/TransferItem/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Equip an item.  You must have a valid Destiny Account, and either be in a social space, in orbit, or offline.
        ///</summary>
        public dynamic EquipItem()
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Actions/Items/EquipItem/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Equip a list of items by itemInstanceIds.  You must have a valid Destiny Account, and either be in a social space, in orbit, or offline.  Any items not found on your character will be ignored.
        ///</summary>
        public dynamic EquipItems()
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Actions/Items/EquipItems/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Set the Lock State for an instanced item.  You must have a valid Destiny Account.
        ///</summary>
        public dynamic SetItemLockState()
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Actions/Items/SetLockState/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Insert a plug into a socketed item.  I know how it sounds, but I assure you it's much more G-rated than you might be guessing.  We haven't decided yet whether this will be able to insert plugs that have side effects, but if we do it will require special scope permission for an application attempting to do so.  You must have a valid Destiny Account, and either be in a social space, in orbit, or offline.  PREVIEW: This service is not yet active, but we are returning the planned schema of the endpoint for review, comment, and preparation for its eventual implementation.
        ///</summary>
        public dynamic InsertSocketPlug()
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Actions/Items/InsertSocketPlug/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Activate a Talent Node.  Chill out, everyone: we haven't decided yet whether this will be able to activate nodes with costs, but if we do it will require special scope permission for an application attempting to do so.  You must have a valid Destiny Account, and either be in a social space, in orbit, or offline.  PREVIEW: This service is not actually implemented yet, but we are returning the planned schema of the endpoint for review, comment, and preparation for its eventual implementation.
        ///</summary>
        public dynamic ActivateTalentNode()
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Actions/Items/ActivateTalentNode/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets the available post game carnage report for the activity ID.
        ///</summary>
        /// <param name="activityId">The ID of the activity whose PGCR is requested.</param>
        public dynamic GetPostGameCarnageReport(int activityId)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Stats/PostGameCarnageReport/{activityId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("activityId", activityId);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets historical stats definitions.
        ///</summary>
        public dynamic GetHistoricalStatsDefinition()
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Stats/Definition/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        ///</summary>
        /// <param name="groupId">Group ID of the clan whose leaderboards you wish to fetch.</param>
        /// <param name="maxtop">Maximum number of top players to return. Use a large number to get entire leaderboard.</param>
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param>
        /// <param name="statid">ID of stat to return rather than returning all Leaderboard stats.</param>
        public dynamic GetClanLeaderboards(int groupId, int maxtop, string modes, string statid)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Stats/Leaderboards/Clans/{groupId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("groupId", groupId);
            request.AddParameter("maxtop", maxtop);
            request.AddParameter("modes", modes);
            request.AddParameter("statid", statid);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets aggregated stats for a clan using the same categories as the clan leaderboards.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        ///</summary>
        /// <param name="groupId">Group ID of the clan whose leaderboards you wish to fetch.</param>
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param>
        public dynamic GetClanAggregateStats(int groupId, string modes)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Stats/AggregateClanStats/{groupId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("groupId", groupId);
            request.AddParameter("modes", modes);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus.  PREVIEW: This endpoint has not yet been implemented.  It is being returned for a preview of future functionality, and for public comment/suggestion/preparation.
        ///</summary>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="maxtop">Maximum number of top players to return. Use a large number to get entire leaderboard.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param>
        /// <param name="statid">ID of stat to return rather than returning all Leaderboard stats.</param>
        public dynamic GetLeaderboards(int destinyMembershipId, int maxtop, BungieMembershipType membershipType, string modes, string statid)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/Leaderboards/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("destinyMembershipId", destinyMembershipId);
            request.AddParameter("maxtop", maxtop);
            request.AddParameter("membershipType", membershipType);
            request.AddParameter("modes", modes);
            request.AddParameter("statid", statid);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        ///</summary>
        /// <param name="characterId">The specific character to build the leaderboard around for the provided Destiny Membership.</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="maxtop">Maximum number of top players to return. Use a large number to get entire leaderboard.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param>
        /// <param name="statid">ID of stat to return rather than returning all Leaderboard stats.</param>
        public dynamic GetLeaderboardsForCharacter(int characterId, int destinyMembershipId, int maxtop, BungieMembershipType membershipType, string modes, string statid)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Stats/Leaderboards/{membershipType}/{destinyMembershipId}/{characterId}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("characterId", characterId);
            request.AddParameter("destinyMembershipId", destinyMembershipId);
            request.AddParameter("maxtop", maxtop);
            request.AddParameter("membershipType", membershipType);
            request.AddParameter("modes", modes);
            request.AddParameter("statid", statid);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets a page list of Destiny items.
        ///</summary>
        /// <param name="page">Page number to return, starting with 0.</param>
        /// <param name="searchTerm">The string to use when searching for Destiny entities.</param>
        /// <param name="type">The type of entity for whom you would like results.  These correspond to the entity's definition contract name.  For instance, if you are looking for items, this property should be 'DestinyInventoryItemDefinition'.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is tentatively in final form, but there may be bugs that prevent desirable operation.</param>
        public dynamic SearchDestinyEntities(int page, string searchTerm, string type)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Armory/Search/{type}/{searchTerm}/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("page", page);
            request.AddParameter("searchTerm", searchTerm);
            request.AddParameter("type", type);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets historical stats for indicated character.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        ///</summary>
        /// <param name="characterId">The id of the character to retrieve. You can omit this character ID or set it to 0 to get aggregate stats across all characters.</param>
        /// <param name="dayend">Last day to return when daily stats are requested.  Use the format YYYY-MM-DD.</param>
        /// <param name="daystart">First day to return when daily stats are requested. Use the format YYYY-MM-DD</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="groups">Group of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="modes">Game modes to return. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param>
        /// <param name="periodType">Indicates a specific period type to return. Optional. May be: Daily, AllTime, or Activity</param>
        public dynamic GetHistoricalStats(int characterId, string dayend, string daystart, int destinyMembershipId, object[] groups, BungieMembershipType membershipType, object[] modes, Destiny.HistoricalStats.Definitions.PeriodType periodType)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("characterId", characterId);
            request.AddParameter("dayend", dayend);
            request.AddParameter("daystart", daystart);
            request.AddParameter("destinyMembershipId", destinyMembershipId);
            request.AddParameter("groups", groups);
            request.AddParameter("membershipType", membershipType);
            request.AddParameter("modes", modes);
            request.AddParameter("periodType", periodType);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets aggregate historical stats organized around each character for a given account.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        ///</summary>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="groups">Groups of stats to include, otherwise only general stats are returned.  Comma separated list is allowed. Values: General, Weapons, Medals.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        public dynamic GetHistoricalStatsForAccount(int destinyMembershipId, object[] groups, BungieMembershipType membershipType)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("destinyMembershipId", destinyMembershipId);
            request.AddParameter("groups", groups);
            request.AddParameter("membershipType", membershipType);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets activity history stats for indicated character.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        ///</summary>
        /// <param name="characterId">The id of the character to retrieve.</param>
        /// <param name="count">Number of rows to return</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="mode">A filter for the activity mode to be returned. None returns all activities. See the documentation for DestinyActivityModeType for valid values, and pass in string representation.</param>
        /// <param name="page">Page number to return, starting with 0.</param>
        public dynamic GetActivityHistory(int characterId, int count, int destinyMembershipId, BungieMembershipType membershipType, Destiny.HistoricalStats.Definitions.DestinyActivityModeType mode, int page)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/Activities/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("characterId", characterId);
            request.AddParameter("count", count);
            request.AddParameter("destinyMembershipId", destinyMembershipId);
            request.AddParameter("membershipType", membershipType);
            request.AddParameter("mode", mode);
            request.AddParameter("page", page);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets details about unique weapon usage, including all exotic weapons.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        ///</summary>
        /// <param name="characterId">The id of the character to retrieve.</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        public dynamic GetUniqueWeaponHistory(int characterId, int destinyMembershipId, BungieMembershipType membershipType)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/UniqueWeapons/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("characterId", characterId);
            request.AddParameter("destinyMembershipId", destinyMembershipId);
            request.AddParameter("membershipType", membershipType);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets all activities the character has participated in together with aggregate statistics for those activities.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        ///</summary>
        /// <param name="characterId">The specific character whose activities should be returned.</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        public dynamic GetDestinyAggregateActivityStats(int characterId, int destinyMembershipId, BungieMembershipType membershipType)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/AggregateActivityStats/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("characterId", characterId);
            request.AddParameter("destinyMembershipId", destinyMembershipId);
            request.AddParameter("membershipType", membershipType);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets custom localized content for the milestone of the given hash, if it exists.
        ///</summary>
        /// <param name="milestoneHash">The identifier for the milestone to be returned.</param>
        public dynamic GetPublicMilestoneContent(int milestoneHash)
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Milestones/{milestoneHash}/Content/");
            request.AddHeader("X-API-KEY", APIKey);
            request.AddParameter("milestoneHash", milestoneHash);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }


        ///<summary>
        ///Gets public information about currently available Milestones.
        ///</summary>
        public dynamic GetPublicMilestones()
        {
            RestClient _client = new RestClient("http://www.bungie.net/d1/Platform/Destiny");
            var request = new RestRequest($"/Destiny2/Milestones/");
            request.AddHeader("X-API-KEY", APIKey);
            var response = _client.Execute(request);
            dynamic deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return deserializedResponse;
        }

    }
}