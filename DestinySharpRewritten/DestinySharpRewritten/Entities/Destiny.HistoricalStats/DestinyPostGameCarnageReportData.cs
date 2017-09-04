
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.HistoricalStats
{
    public class DestinyPostGameCarnageReportData
    {
        public string period;
        public Destiny.HistoricalStats.DestinyPostGameCarnageReportEntry[] entries;
        public Destiny.HistoricalStats.DestinyPostGameCarnageReportTeamEntry[] teams;
    }
}