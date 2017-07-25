using System;
using System.Collections.Generic;
using System.Text;

namespace DestinySharp.Core
{
    public class Stats
    {
        public STATDEFENSE STAT_DEFENSE { get; set; }
        public STATINTELLECT STAT_INTELLECT { get; set; }
        public STATDISCIPLINE STAT_DISCIPLINE { get; set; }
        public STATSTRENGTH STAT_STRENGTH { get; set; }
        public STATLIGHT STAT_LIGHT { get; set; }
        public STATARMOR STAT_ARMOR { get; set; }
        public STATAGILITY STAT_AGILITY { get; set; }
        public STATRECOVERY STAT_RECOVERY { get; set; }
        public STATOPTICS STAT_OPTICS { get; set; }
    }
    public class STATDEFENSE
    {
        public ulong statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATINTELLECT
    {
        public ulong statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATDISCIPLINE
    {
        public ulong statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATSTRENGTH
    {
        public ulong statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATLIGHT
    {
        public ulong statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATARMOR
    {
        public ulong statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATAGILITY
    {
        public ulong statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATRECOVERY
    {
        public ulong statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATOPTICS
    {
        public ulong statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }
}
