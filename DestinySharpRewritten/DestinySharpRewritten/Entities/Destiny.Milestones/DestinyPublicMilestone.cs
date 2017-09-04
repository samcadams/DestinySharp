
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Milestones
{
    public class DestinyPublicMilestone
    {
        public int milestoneHash;
        public Destiny.Milestones.DestinyPublicMilestoneQuest[] availableQuests;
        public UInt32[] vendorHashes;
        public string startDate;
        public string endDate;
    }
}