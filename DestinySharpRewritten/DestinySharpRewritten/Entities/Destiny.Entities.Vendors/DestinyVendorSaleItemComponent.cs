
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Entities.Vendors
{
    public class DestinyVendorSaleItemComponent
    {
        public int vendorItemIndex;
        public int itemHash;
        public Destiny.DestinyItemQuantity[] costs;
        public UInt32[] requiredUnlocks;
        public Destiny.DestinyUnlockStatus[] unlockStatuses;
        public int[] failureIndexes;
    }
}