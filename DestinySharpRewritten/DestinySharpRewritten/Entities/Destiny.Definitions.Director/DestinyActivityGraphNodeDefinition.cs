
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions.Director
{
    public class DestinyActivityGraphNodeDefinition
    {
        public int nodeId;
        public Destiny.Definitions.Director.DestinyActivityGraphNodeFeaturingStateDefinition[] featuringStates;
        public Destiny.Definitions.Director.DestinyActivityGraphNodeActivityDefinition[] activities;
    }
}