namespace DestinySharp.Core.Entities
{
    public class Destination
    {
        public ulong DestinationHash { get; set; }
        public string DestinationName { get; set; }
        public string DestinationDescription { get; set; }
        public string Icon { get; set; }
        public ulong PlaceHash { get; set; }
        public string DestinationIdentifier { get; set; }
        public string LocationIdentifier { get; set; }
    }
}
