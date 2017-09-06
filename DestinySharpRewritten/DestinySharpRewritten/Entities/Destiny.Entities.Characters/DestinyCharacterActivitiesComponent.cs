
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Entities.Characters
{
    public class DestinyCharacterActivitiesComponent
    {
		public string dateActivityStarted;
		public Destiny.DestinyActivity[] availableActivities;
		public ulong currentActivityHash;
		public ulong currentActivityModeHash;
		public ulong lastCompletedStoryHash;
	}
}