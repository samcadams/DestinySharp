using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class ActivityBundle : ManifestDefinition
    {
        public ulong BundleHash { get; set; }
        public string ActivityName { get; set; }
        public string ActivityDescription { get; set; }
        public string Icon { get; set; }
        public string ReleaseIcon { get; set; }
        public int ReleaseTime { get; set; }
        public ulong DestinationHash { get; set; }
        public ulong PlaceHash { get; set; }
        public ulong ActivityTypeHash { get; set; }
        public List<ulong> activityHashes { get; set; }
    }
}
