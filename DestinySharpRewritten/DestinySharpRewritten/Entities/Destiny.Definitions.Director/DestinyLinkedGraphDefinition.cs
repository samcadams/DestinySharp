
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions.Director
{
    public class DestinyLinkedGraphDefinition
    {
        public string description;
        public string name;
        public Destiny.Definitions.DestinyUnlockExpressionDefinition unlockExpression;
        public int linkedGraphId;
        public Destiny.Definitions.Director.DestinyLinkedGraphEntryDefinition[] linkedGraphs;
        public string overview;
    }
}