namespace DestinySharp.Core.Entities
{
    public class ActivityType : ManifestDefinition
    {
        public ulong ActivityTypeHash { get; set; }
        public string Identifier { get; set; }
        public string ActivityTypeName { get; set; }
        public string ActivityTypeDescription { get; set; }
        public string Icon { get; set; }
        public string ActiveBackgroundVirtualPath { get; set; }
        public string CompletedBackgroundVirtualPath { get; set; }
        public string HiddenOverrideVirtualPath { get; set; }
        public string EnlargedActiveBackgroundVirtualPath { get; set; }
        public string EnlargedCompletedBackgroundVirtualPath { get; set; }
        public string EnlargedHiddenOverrideVirtualPath { get; set; }
        public string EnlargedToolTipBackgroundVirtualPath { get; set; }
        public ulong Order { get; set; }
        public string StatGroup { get; set; }
        public string FriendlyUrlId { get; set; }
    }
}
