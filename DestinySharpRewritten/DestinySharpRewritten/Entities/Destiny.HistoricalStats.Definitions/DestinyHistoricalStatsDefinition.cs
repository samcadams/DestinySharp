
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.HistoricalStats.Definitions
{
    public class DestinyHistoricalStatsDefinition
    {
        public string statId;
        public Destiny.HistoricalStats.Definitions.PeriodType[] periodTypes;
        public Destiny.HistoricalStats.Definitions.DestinyActivityModeType[] modes;
        public string statName;
        public string statDescription;
        public string iconImage;
        public int mergeMethod;
        public string unitLabel;
        public int weight;
        public int medalTierHash;
    }
}