namespace DestinySharp.Core.Entities
{
    public class UnlockFlag : ManifestDefinition
    {
        public ulong FlagHash { get; set; }
        public string DisplayName { get; set; }
        public bool IsOffer { get; set; }
        public int UnlockType { get; set; }
    }
}
