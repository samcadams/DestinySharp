
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Milestones
{
    public class DestinyMilestone
    {
        public int milestoneHash;
        public Destiny.Milestones.DestinyMilestoneQuest[] availableQuests;
        public UInt32[] vendorHashes;
        public Destiny.Milestones.DestinyMilestoneRewardCategory[] rewards;
        public string startDate;
        public string endDate;
    }
}