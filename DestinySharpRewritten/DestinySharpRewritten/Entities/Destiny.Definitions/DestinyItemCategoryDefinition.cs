
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyItemCategoryDefinition
    {
        public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition displayProperties;
        public bool visible;
        public string shortTitle;
        public string itemTypeRegex;
        public string itemTypeRegexNot;
        public string originBucketIdentifier;
        public UInt32[] groupedCategoryHashes;
        public int hash;
        public int index;
        public bool redacted;
    }
}