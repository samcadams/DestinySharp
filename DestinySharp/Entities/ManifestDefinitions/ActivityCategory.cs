using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class ActivityCategory : ManifestDefinition
    {
        public string Title { get; set; }
        public string Identifier { get; set; }
        public string Description { get; set; }
        public string HelpTitle { get; set; }
        public string Image { get; set; }
        public ActivityCategoryLinks[] Links { get; set; }
        public List<ulong> parentHashes { get; set; }
        public int Order { get; set; }
        public bool HasHelpContent { get; set; }
        public string ResetIdentifier { get; set; }
    }
    public class ActivityCategoryLinks
    {
        public string Title { get; set; }
        public string Url { get; set; }
    }
}