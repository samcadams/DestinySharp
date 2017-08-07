using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class ActivityMode : ManifestDefinition
    {
        public string ModeName { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string PgcrImage { get; set; }
        public DestinyActivityMode ModeType { get; set; }
        public int ActivityModeCategory { get; set; }
        public int Tier { get; set; }
        public ulong ActivityTypeHash { get; set; }
        public bool isAggregateMode { get; set; }
        public List<ulong> ParentHashes { get; set; }
        public string FriendlyName { get; set; }
        public bool SupportsFeedFiltering { get; set; }
        public Dictionary<ulong, ulong> ActivityModeMappings { get; set; }
        public bool Display { get; set; }
        public int Order { get; set; }
    }
}