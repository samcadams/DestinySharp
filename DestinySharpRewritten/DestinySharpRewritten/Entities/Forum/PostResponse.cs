
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Forum
{
    public class PostResponse
    {
		public string lastReplyTimestamp;
		public bool IsPinned;
public Forum.ForumMediaType urlMediaType;
		public string thumbnail;
public Forum.ForumPostPopularity popularity;
		public bool isActive;
		public bool isAnnouncement;
		public int userRating;
		public bool userHasRated;
		public bool userHasMutedPost;
		public int latestReplyPostId;
		public int latestReplyAuthorId;
public Ignores.IgnoreResponse ignoreStatus;
		public string locale;
	}
}