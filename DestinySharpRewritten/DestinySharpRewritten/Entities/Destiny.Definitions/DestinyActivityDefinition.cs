
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyActivityDefinition
    {
		public string releaseIcon;
		public int releaseTime;
		public int activityLevel;
		public int activityLightLevel;
		public ulong destinationHash;
		public ulong placeHash;
		public ulong activityTypeHash;
		public int tier;
		public string pgcrImage;
		public Destiny.Definitions.DestinyActivityRewardDefinition[] rewards;
		public Destiny.Definitions.DestinyActivityModifierReferenceDefinition[] modifiers;
		public bool isPlaylist;
		public Destiny.Definitions.DestinyActivityChallengeDefinition[] challenges;
		public Destiny.Definitions.DestinyActivityUnlockStringDefinition[] optionalUnlockStrings;
		public Destiny.Definitions.DestinyActivityGraphListEntryDefinition[] activityGraphList;
		public ulong activityModeHash;
		public bool isPvP;
		public ulong hash;
		public int index;
		public bool redacted;
	}
}