
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Entities.Vendors
{
    public class DestinyVendorComponent
    {
        public int vendorHash;
        public string nextRefreshDate;
        public bool enabled;
        public bool canPurchase;
    }
}