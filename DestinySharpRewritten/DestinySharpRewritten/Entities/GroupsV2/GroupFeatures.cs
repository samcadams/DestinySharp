
using System;
using System.Collections.Generic;
using DestinySharp;

namespace GroupsV2
{
    public class GroupFeatures
    {
		public int maximumMembers;
		public int maximumMembershipsOfGroupType;
public GroupsV2.Capabilities capabilities;
		public BungieMembershipType[] membershipTypes;
		public bool invitePermissionOverride;
		public bool updateCulturePermissionOverride;
		public bool updateBannerPermissionOverride;
	}
}