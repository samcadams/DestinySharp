using System;
using System.Collections.Generic;
using System.Text;
using DestinySharp.Core.DataTypes;

namespace DestinySharp.Core
{
    public class ActivityData
    {
        public List<HashedActivity> activities { get; set; }
    }
}

namespace DestinySharp.Core.DataTypes
{ 

    public class HashedActivity
    {
        public DateTime period { get; set; }
        public HashedActivityDetails activityDetails { get; set; }
        public Dictionary<string,HashedActivityValues> values { get; set; }
    }

    public class HashedActivityDetails
    {
        public ulong referenceId { get; set; }
        public string instanceId { get; set; }
        public int mode { get; set; }
        public ulong activityTypeHashOverride { get; set; }
        public bool isPrivate { get; set; }
    }

    public class HashedActivityValues
    {
        public string statID { get; set; }
        public SubHashedActivityValues values { get; set; }
    }
    public class SubHashedActivityValues
    {
        public object value { get; set; }
        public object displayValue { get; set; }
    }
}

