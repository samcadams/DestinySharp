namespace DestinySharp.Core.Entities
{
    public class Stat : ManifestDefinition
    {
        public ulong StatHash { get; set; }
        public string StatName { get; set; }
        public string StatDescription { get; set; }
        public string Icon { get; set; }
        public string StatIdentifier { get; set; }
        public AggregationType AggregationType { get; set; }
        public bool HasComputedBlock { get; set; }
        public bool Interpolate { get; set; }
    }
}
