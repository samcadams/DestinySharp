
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyItemInventoryBlockDefinition
    {
        public string stackUniqueLabel;
        public int maxStackSize;
        public int bucketTypeHash;
        public int recoveryBucketTypeHash;
        public int tierTypeHash;
        public bool isInstanceItem;
        public string tierTypeName;
    }
}