namespace DestinySharp.Core.Entities
{
    public class VendorCategories : ManifestDefinition
    {
        public ulong CategoryHash { get; set; }
        public ulong Order { get; set; }
        public string CategoryName { get; set; }
        public string MobileBannerPath { get; set; }
        public string Identifier { get; set; }
    }
}
