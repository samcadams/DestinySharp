namespace DestinySharp.Core.Entities
{
    public class Objective : ManifestDefinition
    {
        public ulong ObjectiveHash { get; set; }
        public ulong UnlockValueHash { get; set; }
        public int CompletionValue { get; set; }
        public ulong VendorHash { get; set; }
        public ulong VendorCategoryHash { get; set; }
        public string DisplayDescription { get; set; }
        public ulong LocationHash { get; set; }
        public bool AllowNegativeValue { get; set; }
        public bool AllowValueChangeWhenCompleted { get; set; }
        public bool IsCountingDownward { get; set; }
        public int ValueStyle { get; set; }
        public string ContentIdentifier { get; set; }
    }
}