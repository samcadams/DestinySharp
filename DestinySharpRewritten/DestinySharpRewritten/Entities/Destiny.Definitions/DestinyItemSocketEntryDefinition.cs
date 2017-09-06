
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyItemSocketEntryDefinition
    {
		public ulong socketTypeHash;
		public ulong singleInitialItemHash;
		public Destiny.Definitions.DestinyItemSocketEntryPlugItemDefinition[] reusablePlugItems;
	}
}