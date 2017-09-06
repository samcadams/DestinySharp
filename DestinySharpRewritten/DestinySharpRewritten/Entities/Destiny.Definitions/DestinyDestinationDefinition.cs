
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyDestinationDefinition
    {
public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition displayProperties;
		public ulong placeHash;
		public ulong defaultFreeroamActivityHash;
		public Destiny.Definitions.DestinyActivityGraphListEntryDefinition[] activityGraphEntries;
		public Destiny.Definitions.DestinyDestinationBubbleSettingDefinition[] bubbleSettings;
		public Destiny.Definitions.DestinyBubbleDefinition[] bubbles;
		public ulong hash;
		public int index;
		public bool redacted;
	}
}