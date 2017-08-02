using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class StatGroup : ManifestDefinition
    {
        public ulong StatGroupHash { get; set; }
        public int MaximumValue { get; set; }
        public int UiPosition { get; set; }
        public List<StatGroupScaledStats> ScaledStats { get; set; }
        public Dictionary<string, StatGroupOverride> Overrides { get; set; }
    }
    public class StatGroupOverride
    {
        public ulong StatHash { get; set; }
        public string DisplayName { get; set; }
        public string DisplayDescription { get; set; }
        public string DisplayIcon { get; set; }
    }

    public class StatGroupScaledStats {
        public ulong StatHash { get; set; }
        public int MaximumValue { get; set; }
        public bool DisplayAsNumeric { get; set; }
        public StatGroupScaledStatsDisplayInterpolation DisplayInterpolation { get; set; }
    }
    public class StatGroupScaledStatsDisplayInterpolation
    {
        public int Value { get; set; }
        public int Weight { get; set; }
    }
}
