
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyItemActionBlockDefinition
    {
        public string verbName;
        public string verbDescription;
        public bool isPositive;
        public string overlayScreenName;
        public string overlayIcon;
        public int requiredCooldownSeconds;
        public Destiny.Definitions.DestinyItemActionRequiredItemDefinition[] requiredItems;
        public Destiny.Definitions.DestinyProgressionRewardDefinition[] progressionRewards;
        public string actionTypeLabel;
        public string requiredLocation;
        public int requiredCooldownHash;
        public bool deleteOnAction;
        public bool consumeEntireStack;
        public bool useOnAcquire;
    }
}