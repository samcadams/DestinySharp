using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class Bonds : ManifestDefinition
    {
        public string DisplayIcon { get; set; }
        public List<ulong> QuestItemHashes { get; set; }
        public long ProvidedUnlockHash { get; set; }
        public int ProvidedUnlockValueHash { get; set; }
        public bool ShowInAdvisor { get; set; }
        public string ContentIdentifier { get; set; }
    }
}