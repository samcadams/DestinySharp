
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Forum
{
    public class PollResult
    {
        public string answerText;
        public int answerSlot;
        public string lastVoteDate;
        public int votes;
        public bool requestingUserVoted;
    }
}