
using System;
using System.Collections.Generic;
using DestinySharp;

namespace GroupsV2
{
    public class GroupV2
    {
		public int groupId;
		public string name;
public GroupsV2.GroupType groupType;
		public int membershipIdCreated;
		public string creationDate;
		public string modificationDate;
		public string about;
		public string[] tags;
		public int memberCount;
		public bool isPublic;
		public bool isPublicTopicAdminOnly;
		public int primaryAlliedGroupId;
		public string motto;
		public bool allowChat;
		public bool isDefaultPostPublic;
public GroupsV2.ChatSecuritySetting chatSecurity;
		public string locale;
		public int avatarImageIndex;
public GroupsV2.GroupHomepage homepage;
public GroupsV2.MembershipOption membershipOption;
public GroupsV2.GroupPostPublicity defaultPublicity;
		public string theme;
		public string bannerPath;
		public string avatarPath;
		public bool isAllianceOwner;
		public int conversationId;
		public bool enableInvitationMessagingForAdmins;
		public string banExpireDate;
public GroupsV2.GroupFeatures features;
public GroupsV2.GroupV2ClanInfoAndInvestment clanInfo;
	}
}