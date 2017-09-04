
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyTalentGridDefinition
    {
        public int maxGridLevel;
        public int gridLevelPerColumn;
        public int progressionHash;
        public Destiny.Definitions.DestinyTalentNodeDefinition[] nodes;
        public Destiny.Definitions.DestinyTalentNodeExclusiveSetDefinition[] exclusiveSets;
        public int[] independentNodeIndexes;
        public Destiny.Definitions.DestinyTalentNodeCategory[] nodeCategories;
        public int hash;
        public int index;
        public bool redacted;
    }
}