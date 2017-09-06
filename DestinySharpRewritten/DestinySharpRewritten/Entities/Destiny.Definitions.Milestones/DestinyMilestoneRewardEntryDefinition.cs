
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions.Milestones
{
    public class DestinyMilestoneRewardEntryDefinition
    {
		public ulong rewardEntryHash;
		public string rewardEntryIdentifier;
		public Destiny.DestinyItemQuantity[] items;
		public ulong vendorHash;
		public int order;
	}
}