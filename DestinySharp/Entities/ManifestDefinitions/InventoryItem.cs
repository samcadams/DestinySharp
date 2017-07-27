using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class InventoryItem : ManifestDefinition
    {
        public ulong ItemHash { get; set; }
        public string ItemName { get; set; }
        public string Icon { get; set; }
        public bool hasIcon { get; set; }
        public string SecondaryIcon { get; set; }
        public string DisplaySource { get; set; }
        public string ActionName { get; set; }
        public string ActionDescription { get; set; }
        public bool HasAction { get; set; }
        public bool DeleteOnAction { get; set; }
        public TierType TierType { get; set; }
        public ulong BucketTypeHash { get; set; }
        public ulong PrimaryBaseStatHash { get; set; }
        public List<object> Stats { get; set; }
        public object[] PerkHashes { get; set; }
        public SpecialItemType SpecialItemType { get; set; }
        public ulong TalentGridHash { get; set; }
        public bool HasGeometry { get; set; }
        public ulong StatGroupHash { get; set; }
        public object[] ItemLevels { get; set; }
        public int QualityLevel { get; set; }
        public bool Equippable { get; set; }
        public bool Instanced { get; set; }
        public ulong RewardItemHash { get; set; }
        public List<object> Values { get; set; }
        public int ItemType { get; set; }
        public int SubItemType { get; set; }
        public ClassType ClassType { get; set; }
        public ulong[] ItemCategoryHashes { get; set; }
        public ulong[] SourceHashes { get; set; }
        public bool NonTransferrable { get; set; }
        public int Exclusive { get; set; }
        public int MaxStackSize { get; set; }
        public int ItemIndex { get; set; }
        public ulong[] SetItemHashes { get; set;}
        public string ToolTipStyle { get; set; }
        public ulong QuestlineItemHash { get; set; }
        public bool NeedsFullCompletion { get; set; }
        public ulong[] ObjectiveHashes { get; set; }
        public bool AllowActions { get; set; }
        public ulong QuestTrackingUnlockValueHash { get; set; }
        public ulong BountyResetUnlockHash { get; set; }
        public ulong UniquenessHash { get; set; }
        public bool ShowActiveNodesInTooltip { get; set; }
    }
}
