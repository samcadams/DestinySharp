
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Progression
{
    public class DestinyFactionProgression
    {
		public ulong factionHash;
		public ulong progressionHash;
		public int dailyProgress;
		public int dailyLimit;
		public int weeklyProgress;
		public int weeklyLimit;
		public int currentProgress;
		public int level;
		public int levelCap;
		public int stepIndex;
		public int progressToNextLevel;
		public int nextLevelAt;
	}
}