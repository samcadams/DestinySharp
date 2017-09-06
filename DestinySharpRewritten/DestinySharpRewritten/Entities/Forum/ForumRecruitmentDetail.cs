
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Forum
{
    public class ForumRecruitmentDetail
    {
		public int topicId;
		public bool microphoneRequired;
public Forum.ForumRecruitmentIntensityLabel intensity;
public Forum.ForumRecruitmentToneLabel tone;
		public bool approved;
		public int conversationId;
		public int playerSlotsTotal;
		public int playerSlotsRemaining;
		public User.GeneralUser[] Fireteam;
		public ulong[] kickedPlayerIds;
	}
}