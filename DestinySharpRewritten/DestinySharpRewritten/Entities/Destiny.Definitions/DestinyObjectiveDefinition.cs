
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyObjectiveDefinition
    {
        public int completionValue;
        public int locationHash;
        public bool allowNegativeValue;
        public bool allowValueChangeWhenCompleted;
        public bool isCountingDownward;
        public string progressDescription;
        public int hash;
        public int index;
        public bool redacted;
    }
}