using System;
using System.Collections.Generic;
using DestinySharp.Core.DataTypes;

namespace DestinySharp.Core
{
    /// <summary>
    /// Quote from Official Bungie Documentation: "Returns the set of Advisor data for the given account. This endpoint only returns advisors that are relevant on an account level, and will likely grow over time."
    /// </summary>
    public class AdvisorData
    {
        public DateTime nextWeeklyReset { get; set; }
        public DateTime nextDailyReset { get; set; }
        public DateTime previousWeeklyReset { get; set; }
        public DateTime previousDailyReset { get; set; }
        public Dictionary<ulong, HashedRecordBook> recordBooks { get; set; }
    }
}

namespace DestinySharp.Core.DataTypes
{
    public class HashedRecordBook
    {
        public ulong bookHash { get; set; }
        public Dictionary<ulong, HashedRecord> records { get; set; }
        public HashedRecordBookProgression progression { get; set; }
        public int completedCount { get; set; }
        public int redeemedCount { get; set; }
        public IList<HashedRecordBookSpotlights> spotlights { get; set; }
        public DateTime startDate { get; set; }
        public DateTime expirationDate { get; set; }
    }

    public class HashedRecord
    {
        public ulong recordHash { get; set; }
        public IList<HashedRecordObjective> objectives { get; set; }
        public int status { get; set; }
        public bool scramble { get; set; }
    }

    public class HashedRecordBookProgression
    {
        public int dailyProgress { get; set; }
        public int weeklyProgress { get; set; }
        public int currentProgress { get; set; }
        public int level { get; set; }
        public int step { get; set; }
        public int progressToNextLevel { get; set; }
        public int nextLevelAt { get; set; }
        public ulong progressionHash { get; set; }
    }

    public class HashedRecordObjective
    {
        public ulong objectiveHash { get; set; }
        public ulong destinationHash { get; set; }
        public ulong activityHash { get; set; }
        public int progress { get; set; }
        public bool hasProgress { get; set; }
        public bool isComplete { get; set; }
        public dynamic displayValue { get; set; }
    }

    public class HashedRecordBookSpotlights
    {
        public ulong rewardItemHash { get; set; }
        public int rewardedAtLevel { get; set; }
        public int quantity { get; set; }
        public int status { get; set; }
    }
}
