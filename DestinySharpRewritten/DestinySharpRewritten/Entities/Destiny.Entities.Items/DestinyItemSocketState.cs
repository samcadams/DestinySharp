
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Entities.Items
{
    public class DestinyItemSocketState
    {
		public ulong plugHash;
		public bool isEnabled;
		public int[] enableFailIndexes;
		public UInt32[] reusablePlugHashes;
	}
}