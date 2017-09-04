
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.HistoricalStats
{
    public class DestinyHistoricalStatsAccountResult
    {
        public Destiny.HistoricalStats.DestinyHistoricalStatsWithMerged mergedDeletedCharacters;
        public Destiny.HistoricalStats.DestinyHistoricalStatsWithMerged mergedAllCharacters;
        public Destiny.HistoricalStats.DestinyHistoricalStatsPerCharacter[] characters;
    }
}