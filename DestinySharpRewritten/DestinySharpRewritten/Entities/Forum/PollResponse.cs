
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Forum
{
    public class PollResponse
    {
		public int topicId;
		public Forum.PollResult[] results;
		public int totalVotes;
	}
}