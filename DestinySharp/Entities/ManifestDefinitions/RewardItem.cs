using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class Reward
    {
        public List<RewardItem> RewardItems { get; set; }
    }

    public class RewardItem
    {
        public long ItemHash { get; set; }
        public int Value { get; set; }
    }
}
