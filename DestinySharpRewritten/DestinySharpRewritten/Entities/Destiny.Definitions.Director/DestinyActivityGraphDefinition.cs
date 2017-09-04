
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions.Director
{
    public class DestinyActivityGraphDefinition
    {
        public Destiny.Definitions.Director.DestinyActivityGraphNodeDefinition[] nodes;
        public Destiny.Definitions.Director.DestinyActivityGraphArtElementDefinition[] artElements;
        public Destiny.Definitions.Director.DestinyActivityGraphConnectionDefinition[] connections;
        public Destiny.Definitions.Director.DestinyActivityGraphDisplayObjectiveDefinition[] displayObjectives;
        public Destiny.Definitions.Director.DestinyActivityGraphDisplayProgressionDefinition[] displayProgressions;
        public Destiny.Definitions.Director.DestinyLinkedGraphDefinition[] linkedGraphs;
        public int hash;
        public int index;
        public bool redacted;
    }
}