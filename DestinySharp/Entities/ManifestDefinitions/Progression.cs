using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class Progression : ManifestDefinition
    {
        public ulong ProgressionHash { get; set; }
        public string Name { get; set; }
        public int Scope { get; set; }
        public bool RepeatLastStep { get; set; }
        public string Icon { get; set; }
        public List<ProgressionStep> Steps { get; set; }
        public bool Visible { get; set; }
    }
    
    public class ProgressionStep
    {
        public int ProgressTotal { get; set; }
        public List<RewardItem> RewardItems { get; set; }
    }
}
