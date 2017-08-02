namespace DestinySharp.Core.Entities
{
    public class Faction : ManifestDefinition
    {
        public ulong FactionHash { get; set; }
        public string FactionName { get; set; }
        public string FactionDescription { get; set; }
        public string FactionIcon { get; set; }
        public ulong ProgressionHash { get; set; }
    }
}
