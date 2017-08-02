using System;
using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class Vendor : ManifestDefinition
    {
        public VendorSummary Summary { get; set; }
        public List<VendorAcceptedItem> AcceptedItems { get; set; }
        public VendorSaleCategories Categories { get; set; }
        public List<String> FailureStrings { get; set; }
        public List<VendorSales> Sales { get; set; }
        public ulong UnlockValueHash { get; set; }
    }

    public class VendorSummary
    {
        public ulong VendorHash { get; set; }
        public string VendorName { get; set; }
        public string VendorDescription { get; set; }
        public string VendorIcon { get; set; }
        public int VendorOrder { get; set; }
        public ulong FactionHash { get; set; }
        public int ResetIntervalMinutes { get; set; }
        public int ResetOffsetMinutes { get; set; }
        public string VendorIdentifier { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public string TransitionNodeIdentifier { get; set; }
        public bool Visible { get; set; }
        public ulong ProgressionHash { get; set; }
        public string SellString { get; set; }
        public string BuyString { get; set; }
        public string VendorPortrait { get; set; }
        public string VendorBanner { get; set; }
        public List<ulong> UnlockFlagHashes { get; set; }
        public List<ulong> EnabledUnlockFlagHashes { get; set; }
        public string MapSectionIdentifier { get; set; }
        public string MapSectionName { get; set; }
        public int MapSectionOrder { get; set; }
        public bool ShowOnMap { get; set; }
        public ulong EventHash { get; set; }
        public ulong VendorCategoryHash { get; set; }
        public List<ulong> VendorCategoryHashes { get; set; }
        public ulong VendorSbucategoryHash { get; set; }
        public bool InhibitBuying { get; set; }
    }

    public class VendorSaleCategories {
        public ulong CategoryHash { get; set; }
        public int CategoryIndex { get; set; }
        public string DisplayTitle { get; set; }
        public ulong OverlayCurrencyItemHash { get; set; }
        public int QuantityAvailable { get; set; }
        public bool ShowUnavailableItems { get; set; }
        public bool HideIfNoCurrency { get; set; }
        public string OverlayTitle { get; set; }
        public string OverlayDescription { get; set; }
        public string OverlayChoice { get; set; }
        public string OverlayIcon { get; set; }
        public bool HasOverlay { get; set; }
        public bool HideFromRegularPurchase { get; set; }
    }

    public class VendorSales
    {
        public bool PriceOverride { get; set; }
        public ulong ItemHash { get; set; }
        public ulong BucketHash { get; set; }
        public ulong CategoryHash { get; set; }
        public int CategoryIndex { get; set; }
        public int QuantityPurchased { get; set; }
        public ulong LicenseUnlockHash { get; set; }
        public List<ulong> Currencies { get; set; }
        public int Price { get; set; }
        public ulong CurrencyHash { get; set; }
        public bool HasCurrency { get; set; }
        public List<int> failureIndexes { get; set; }
        public int RefundPolicy { get; set; }
        public int RefundLimit { get; set; }
        public int SeedOverride { get; set; }
        public int Weight { get; set; }
        public int RequiredLevel { get; set; }
        public int CreationLevel { get; set; }
        public int SaleItemIndex { get; set; }
        public int OriginalCategoryIndex { get; set; }
        public int MinimumLevel { get; set; }
        public int MaximumLevel { get; set; }
    }

    public class VendorAcceptedItem {
        public ulong AcceptedBucket { get; set; }
        public ulong DestinationBucket { get; set; }
    }
}
