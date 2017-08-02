namespace DestinySharp.Core.Entities
{
    public class RewardSource : ManifestDefinition
    {
        public ulong SourceHash { get; set; }
        public DestinyRewardSourceCategory Category { get; set; }
        public string Identifier { get; set; }
        public string SourceName { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
