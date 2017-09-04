
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyVendorItemDefinition
    {
        public int vendorItemIndex;
        public int itemHash;
        public int quantity;
        public int[] failureIndexes;
        public Destiny.DestinyItemQuantity[] currencies;
        public int refundTimeLimit;
        public Destiny.Definitions.DestinyItemCreationEntryLevelDefinition[] creationLevels;
        public int displayCategoryIndex;
        public int categoryIndex;
        public int originalCategoryIndex;
        public int minimumLevel;
        public int maximumLevel;
        public string displayCategory;
        public int inventoryBucketHash;
    }
}