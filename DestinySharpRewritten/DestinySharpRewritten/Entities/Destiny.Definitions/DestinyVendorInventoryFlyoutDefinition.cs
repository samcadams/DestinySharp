
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyVendorInventoryFlyoutDefinition
    {
		public string lockedDescription;
		public Destiny.Definitions.DestinyVendorInventoryFlyoutBucketDefinition[] buckets;
		public ulong flyoutId;
		public bool suppressNewness;
	}
}