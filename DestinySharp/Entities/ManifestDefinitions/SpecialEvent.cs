using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class SpecialEvent : ManifestDefinition
    {
        public ulong eventHash { get; set; }
        public string eventIdentifier { get; set; }
        public string backgroundImageWeb { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public string icon { get; set; }
        public bool showNagMessage { get; set; }
        public bool returnInActivityAdvisor { get; set; }
        public ulong progressionHash { get; set; }
        public ulong vendorHash { get; set; }
        public ulong factionHash { get; set; }
        public string backgroundImageMobile { get; set; }
        public ulong activeUnlockValueHash { get; set; }
        public List<ulong> bountyHashes { get; set; }
        public List<ulong> questHashes { get; set; }
        public string friendlyIdentifier { get; set; }
        public string[] recruitmentIds { get; set; }
        public ulong playlistActivityHash { get; set; }
        public ulong unlockEventHash { get; set; }
        public DestinyActivityMode activityMode { get; set; }
    }
}