using System;
using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class RecordBook : ManifestDefinition
    {
        public RecordBookAvailableUnlockExpression BookAvailableUnlockExpression { get; set; }
        public List<RecordBookActiveRange> ActiveRanges { get; set; }
        public Page3[] pages { get; set; }
        public string DisplayName { get; set; }
        public string DisplayDescription { get; set; }
        public string Icon { get; set; }
        public string UnavailableReason { get; set; }
        public ulong ProgressionHash { get; set; }
        public int RecordCount { get; set; }
        public string BannerImage { get; set; }
        public ulong ItemHash { get; set; }
        public string ContentIdentifier { get; set; }
    }

    public class RecordBookAvailableUnlockExpression
    {
        public List<RecordBookAvailableUnlockExpressionStep> Steps { get; set; }
    }

    public class RecordBookAvailableUnlockExpressionStep
    {
        public int StepOperator { get; set; }
        public ulong FlagHash { get; set; }
        public ulong ValueHash { get; set; }
        public int Value { get; set; }
    }

    public class RecordBookActiveRange
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

    public class RecordBookPage
    {
        public string DisplayName { get; set; }
        public string DisplayDescription { get; set; }
        public int DisplayStyle { get; set; }
        public List<RecordBookRecord> Records { get; set; }
        public object[] Rewards { get; set; }
    }

    public class RecordBookRecord
    {
        public ulong RecordHash { get; set; }
        public bool Spotlight { get; set; }
        public bool Scrambled { get; set; }
    }

    public class RecordBookReward {
        public bool Visible { get; set; }
        public ulong ItemHash { get; set; }
        public List<RecordBookRewardRequirementUnlockExpressionStepOutter> RequirementUnlockExpressions { get; set; }
        public int RequirementProgressionLevel { get; set; }
        public ulong ClaimedUnlockHash { get; set; }
        public bool CanReclaim { get; set; }
        public int Quantity { get; set; }
    }

    public class RecordBookRewardRequirementUnlockExpressionStepOutter
    {
        List<RecordBookRewardRequirementUnlockExpressionStepInner> Steps { get; set; }
    }

    public class RecordBookRewardRequirementUnlockExpressionStepInner
    {
        public int StepOperator { get; set; }
        public ulong FlagHash { get; set; }
        public ulong ValueHash { get; set; }
        public int Value { get; set; }
    }
}