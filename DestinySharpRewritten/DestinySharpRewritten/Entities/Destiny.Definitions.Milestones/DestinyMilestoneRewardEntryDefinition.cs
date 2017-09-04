
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions.Milestones
{
    public class DestinyMilestoneRewardEntryDefinition
    {
        public int rewardEntryHash;
        public string rewardEntryIdentifier;
        public Destiny.DestinyItemQuantity[] items;
        public int vendorHash;
        public int order;
    }
}