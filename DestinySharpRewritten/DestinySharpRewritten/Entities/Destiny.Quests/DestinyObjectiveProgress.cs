
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Quests
{
    public class DestinyObjectiveProgress
    {
		public ulong objectiveHash;
		public ulong destinationHash;
		public ulong activityHash;
		public int progress;
		public bool complete;
	}
}