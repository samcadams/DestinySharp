
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Requests
{
    public class DestinyItemTransferRequest
    {
		public ulong itemReferenceHash;
		public int stackSize;
		public bool transferToVault;
		public int itemId;
		public int characterId;
public  DestinySharp.BungieMembershipType membershipType;
	}
}