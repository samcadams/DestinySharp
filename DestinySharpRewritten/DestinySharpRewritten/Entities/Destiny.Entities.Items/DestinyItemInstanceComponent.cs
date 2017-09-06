
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Entities.Items
{
    public class DestinyItemInstanceComponent
    {
		public ulong damageTypeHash;
		public int itemLevel;
		public int quality;
		public bool isEquipped;
		public bool canEquip;
		public int equipRequiredLevel;
		public UInt32[] unlockHashesRequiredToEquip;
	}
}