
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyDestinationDefinition
    {
        public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition displayProperties;
        public int placeHash;
        public int defaultFreeroamActivityHash;
        public Destiny.Definitions.DestinyActivityGraphListEntryDefinition[] activityGraphEntries;
        public Destiny.Definitions.DestinyDestinationBubbleSettingDefinition[] bubbleSettings;
        public Destiny.Definitions.DestinyBubbleDefinition[] bubbles;
        public int hash;
        public int index;
        public bool redacted;
    }
}