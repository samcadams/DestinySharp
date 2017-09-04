
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Quests
{
    public class DestinyQuestStatus
    {
        public int questHash;
        public int stepHash;
        public Destiny.Quests.DestinyObjectiveProgress[] stepObjectives;
        public bool tracked;
        public int itemInstanceId;
        public bool completed;
        public bool redeemed;
        public bool started;
        public int vendorHash;
    }
}