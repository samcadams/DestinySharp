
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyTalentNodeDefinition
    {
		public int nodeIndex;
		public ulong nodeHash;
		public int row;
		public int column;
		public int[] prerequisiteNodeIndexes;
		public int binaryPairNodeIndex;
		public bool autoUnlocks;
		public bool lastStepRepeats;
		public bool isRandom;
		public bool isRandomRepurchasable;
		public Destiny.Definitions.DestinyNodeStepDefinition[] steps;
		public UInt32[] exclusiveWithNodeHashes;
		public int randomStartProgressionBarAtProgression;
		public string layoutIdentifier;
		public ulong groupHash;
		public ulong loreHash;
		public string nodeStyleIdentifier;
		public bool ignoreForCompletion;
	}
}