using System.Collections.Generic;

namespace DestinySharp.Core.Entities.ManifestDefinitions
{
    public class Record : ManifestDefinition
    {
            public string DisplayName { get; set; }
            public string Description { get; set; }
            public string RecordValueUIStyle { get; set; }
            public string Icon { get; set; }
            public int Style { get; set; }
            public List<RecordReward> Rewards { get; set; }
            public List<RecordActualRewards> ActualRewards { get; set; }
            public List<RecordObjective> Objectives { get; set; }
            public string ContentIdentifier { get; set; }

        public class RecordReward
        {
            public ulong UiItemHash { get; set; }
            public int UiItemQuantity { get; set; }
            public int LevelRewarded { get; set; }
        }

        public class RecordActualRewards
        {
            public ulong RewardSiteHash { get; set; }
            public RecordItemUnlockExpression ItemUnlockExpression { get; set; }
        }

        public class RecordItemUnlockExpression
        {
            public List<RecordItemUnlockExpression> Steps { get; set; }
        }

        public class RecordItemUnlockExpressionStep
        {
            public int StepOperator { get; set; }
            public ulong FlagHash { get; set; }
            public ulong ValueHash { get; set; }
            public int Value { get; set; }
        }

        public class RecordObjective
        {
            public ulong ObjectiveHash { get; set; }
        }

    }
}
