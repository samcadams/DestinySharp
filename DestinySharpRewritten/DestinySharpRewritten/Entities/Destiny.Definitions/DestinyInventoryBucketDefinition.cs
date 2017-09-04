
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyInventoryBucketDefinition
    {
        public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition displayProperties;
        public int bucketOrder;
        public int itemCount;
        public bool hasTransferDestination;
        public bool enabled;
        public bool fifo;
        public int hash;
        public int index;
        public bool redacted;
    }
}