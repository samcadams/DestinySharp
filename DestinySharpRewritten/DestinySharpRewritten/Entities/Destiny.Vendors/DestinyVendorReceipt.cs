
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Vendors
{
    public class DestinyVendorReceipt
    {
        public Destiny.DestinyItemQuantity[] currencyPaid;
        public int licenseUnlockHash;
        public int purchasedByCharacterId;
        public int sequenceNumber;
        public int timeToExpiration;
        public string expiresOn;
    }
}