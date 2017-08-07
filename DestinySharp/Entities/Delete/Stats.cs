using DestinySharp.Core.DataTypes;

namespace DestinySharp.Core.DataTypes
{
    public class Stats
    {
        public HashedStat STAT_DEFENSE { get; set; }
        public HashedStat STAT_INTELLECT { get; set; }
        public HashedStat STAT_DISCIPLINE { get; set; }
        public HashedStat STAT_STRENGTH { get; set; }
        public HashedStat STAT_LIGHT { get; set; }
        public HashedStat STAT_ARMOR { get; set; }
        public HashedStat STAT_AGILITY { get; set; }
        public HashedStat STAT_RECOVERY { get; set; }
        public HashedStat STAT_OPTICS { get; set; }
    }
    public class HashedStat
    {
        public ulong statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }
}
