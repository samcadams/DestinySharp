
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyItemInventoryBlockDefinition
    {
		public string stackUniqueLabel;
		public int maxStackSize;
		public ulong bucketTypeHash;
		public ulong recoveryBucketTypeHash;
		public ulong tierTypeHash;
		public bool isInstanceItem;
		public string tierTypeName;
	}
}