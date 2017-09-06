
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyTalentGridDefinition
    {
		public int maxGridLevel;
		public int gridLevelPerColumn;
		public ulong progressionHash;
		public Destiny.Definitions.DestinyTalentNodeDefinition[] nodes;
		public Destiny.Definitions.DestinyTalentNodeExclusiveSetDefinition[] exclusiveSets;
		public int[] independentNodeIndexes;
		public Destiny.Definitions.DestinyTalentNodeCategory[] nodeCategories;
		public ulong hash;
		public int index;
		public bool redacted;
	}
}