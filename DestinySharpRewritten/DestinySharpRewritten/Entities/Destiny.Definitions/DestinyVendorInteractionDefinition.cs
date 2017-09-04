
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyVendorInteractionDefinition
    {
        public Destiny.Definitions.DestinyVendorInteractionReplyDefinition[] replies;
        public int vendorCategoryIndex;
        public int questlineItemHash;
        public Destiny.Definitions.DestinyVendorInteractionSackEntryDefinition[] sackInteractionList;
        public int uiInteractionType;
        public string rewardBlockLabel;
        public int rewardVendorCategoryIndex;
        public string flavorLineOne;
        public string flavorLineTwo;
        public string instructions;
    }
}