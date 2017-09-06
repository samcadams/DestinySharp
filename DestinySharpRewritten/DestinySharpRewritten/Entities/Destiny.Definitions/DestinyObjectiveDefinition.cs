
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyObjectiveDefinition
    {
		public int completionValue;
		public ulong locationHash;
		public bool allowNegativeValue;
		public bool allowValueChangeWhenCompleted;
		public bool isCountingDownward;
		public string progressDescription;
		public ulong hash;
		public int index;
		public bool redacted;
	}
}