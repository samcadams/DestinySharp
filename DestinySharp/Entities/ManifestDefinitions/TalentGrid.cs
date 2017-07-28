using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    // I had to download a 38 mb file for these definitions.
    public class TalentGrid : ManifestDefinition
    {
        public ulong GridHash { get; set; }
        public int MaxGridLevel { get; set; }
        public int GridLevelPerColumn { get; set; }
        public ulong ProgressionHash { get; set; }
        public List<TalentGridNode> Nodes { get; set; }
        public int CalcMaxGridLevel { get; set; }
        public int CalcProgressToMaxLevel { get; set; }
        public List<TalentGridExclusiveSet> ExclusiveSets { get; set; }
        public List<ulong> IndependentNodeIndexes { get; set; }
        public int MaximumRandomMaterialRequirements { get; set; }
    }

    public class TalentGridNode
    {
        public int NodeIndex { get; set; }
        public ulong NodeHash { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public List<object> PrerequisiteNodeIndexes { get; set; }
        public int BinaryPairNodeIndex { get; set; }
        public bool AutoUnlocks { get; set; }
        public bool LastStepRepeats { get; set; }
        public bool IsRandom { get; set; }
        public bool IsRandomRepurchasable { get; set; }
        public List<TalentGridStep> Steps { get; set; }
        public List<ulong> ExlusiveWithNodes { get; set; }
        public int RandomStartProgressionBarAtProgress { get; set; }
        public ulong OriginalNodeHash { get; set; }
        public ulong TalentNodeTypes { get; set; }
        public ulong ExclusiveSetHash { get; set; }
        public bool IsRealStepSelectionRandom { get; set; }
    }
    public class TalentGridStep
    {
        public int StepIndex { get; set; }
        public ulong NodeStepHash { get; set; }
        public string NodeStepName { get; set; }
        public string NodeStepDescription { get; set; }
        public string InteractionDescription { get; set; }
        public string Icon { get; set; }
        public DamageType DamageType { get; set; }
        public ulong DamageTypeHash { get; set; }
        public TalentGridStepActivationRequirement ActivationRequirement { get; set; }
        public bool CanActiveNextStep { get; set; }
        public int NextStpeIndex { get; set; }
        public bool IsNextStepRandom { get; set; }
        public List<ulong> PerkHashes { get; set; }
        public int StartProgressionBarAtProgress { get; set; }
        public List<ulong> StatHashes { get; set; }
        public bool AffectsQuality { get; set; }
        public TalentGridStepGroup StepGroups { get; set; }
        public int TrueStepIndex { get; set; }
        public int TruePropertyIndex { get; set; }
        public bool AffectsLevel { get; set; }
    }
    public class TalentGridStepActivationRequirement
    {
        public int GridLevel { get; set; }
        public List<ulong> MaterialRequirementHashes { get; set; }
        public ulong ExclusiveSetRequiredHash { get; set; }
    }
    public class TalentGridStepGroup
    {
        public int WeaponPerformance { get; set; }
        public int ImpactEffects { get; set; }
        public int GuardianAttributes { get; set; }
        public int LightAbilities { get; set; }
        public int DamageTypes { get; set; }
    }
    public class TalentGridExclusiveSet
    {
        public List<ulong> NodeIndexes { get; set; }
    }
}
