namespace DestinySharp.Core.Entities
{
    public class Place : ManifestDefinition
    {
        public ulong PlaceHash { get; set; }
        public string PlaceName { get; set; }
        public string PlaceDescription { get; set; }
        public string Icon { get; set; }
    }
}
