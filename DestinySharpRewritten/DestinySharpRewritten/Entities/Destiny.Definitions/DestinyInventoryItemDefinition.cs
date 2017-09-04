
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyInventoryItemDefinition
    {
        public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition displayProperties;
        public string secondaryIcon;
        public string secondaryOverlay;
        public string secondarySpecial;
        public string screenshot;
        public string itemTypeDisplayName;
        public string itemTypeAndTierDisplayName;
        public string displaySource;
        public string tooltipStyle;
        public Destiny.Definitions.DestinyItemInvestmentStatDefinition[] investmentStats;
        public Destiny.Definitions.DestinyItemPerkEntryDefinition[] perks;
        public int loreHash;
        public int summaryItemHash;
        public Destiny.Definitions.Animations.DestinyAnimationReference[] animations;
        public bool allowActions;
        public Links.HyperlinkReference[] links;
        public bool nonTransferrable;
        public UInt32[] itemCategoryHashes;
        public bool equippable;
        public UInt32[] damageTypeHashes;
        public Destiny.DamageType[] damageTypes;
        public int defaultDamageTypeHash;
        public int hash;
        public int index;
        public bool redacted;
    }
}