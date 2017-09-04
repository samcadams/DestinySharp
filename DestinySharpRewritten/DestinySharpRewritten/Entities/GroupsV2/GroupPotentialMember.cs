
using System;
using System.Collections.Generic;
using DestinySharp;

namespace GroupsV2
{
    public class GroupPotentialMember
    {
        public GroupsV2.GroupPotentialMemberStatus potentialStatus;
        public int groupId;
        public User.UserInfoCard destinyUserInfo;
        public User.UserInfoCard bungieNetUserInfo;
        public string joinDate;
    }
}