
using System;
using System.Collections.Generic;
using DestinySharp;

namespace GroupsV2
{
    public class GroupResponse
    {
public GroupsV2.GroupV2 detail;
public GroupsV2.GroupMember founder;
		public ulong[] alliedIds;
public GroupsV2.GroupV2 parentGroup;
public GroupsV2.GroupAllianceStatus allianceStatus;
		public int groupJoinInviteCount;
	}
}