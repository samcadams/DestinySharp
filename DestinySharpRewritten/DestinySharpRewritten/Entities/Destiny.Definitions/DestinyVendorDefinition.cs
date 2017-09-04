
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyVendorDefinition
    {
        public Destiny.Definitions.DestinyVendorDisplayPropertiesDefinition displayProperties;
        public string buyString;
        public string sellString;
        public int displayItemHash;
        public bool inhibitBuying;
        public bool inhibitSelling;
        public int factionHash;
        public int resetIntervalMinutes;
        public int resetOffsetMinutes;
        public string[] failureStrings;
        public Dates.DateRange[] unlockRanges;
        public string vendorIdentifier;
        public string vendorPortrait;
        public string vendorBanner;
        public bool enabled;
        public bool visible;
        public string vendorCategoryIdentifier;
        public string vendorSubcategoryIdentifier;
        public bool consolidateCategories;
        public Destiny.Definitions.DestinyVendorActionDefinition[] actions;
        public Destiny.Definitions.DestinyVendorCategoryEntryDefinition[] categories;
        public Destiny.Definitions.DestinyVendorCategoryEntryDefinition[] originalCategories;
        public Destiny.Definitions.DestinyDisplayCategoryDefinition[] displayCategories;
        public Destiny.Definitions.DestinyVendorInteractionDefinition[] interactions;
        public Destiny.Definitions.DestinyVendorInventoryFlyoutDefinition[] inventoryFlyouts;
        public Destiny.Definitions.DestinyVendorItemDefinition[] itemList;
        public Destiny.Definitions.DestinyVendorServiceDefinition[] services;
        public Destiny.Definitions.DestinyVendorAcceptedItemDefinition[] acceptedItems;
        public int hash;
        public int index;
        public bool redacted;
    }
}