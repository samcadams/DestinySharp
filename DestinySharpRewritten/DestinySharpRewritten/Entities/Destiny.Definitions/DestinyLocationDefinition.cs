
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyLocationDefinition
    {
		public ulong vendorHash;
		public Destiny.Definitions.DestinyLocationReleaseDefinition[] locationReleases;
		public ulong hash;
		public int index;
		public bool redacted;
	}
}