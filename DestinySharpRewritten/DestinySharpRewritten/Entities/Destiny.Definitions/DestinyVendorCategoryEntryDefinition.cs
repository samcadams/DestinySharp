
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyVendorCategoryEntryDefinition
    {
		public int categoryIndex;
		public string categoryId;
		public ulong categoryHash;
		public int quantityAvailable;
		public bool showUnavailableItems;
		public bool hideIfNoCurrency;
		public bool hideFromRegularPurchase;
		public string buyStringOverride;
		public string disabledDescription;
		public string displayTitle;
	}
}