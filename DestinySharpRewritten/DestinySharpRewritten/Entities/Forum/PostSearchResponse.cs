
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Forum
{
    public class PostSearchResponse
    {
        public Forum.PostResponse[] relatedPosts;
        public User.GeneralUser[] authors;
        public GroupsV2.GroupResponse[] groups;
        public Tags.Models.Contracts.TagResponse[] searchedTags;
        public Forum.PollResponse[] polls;
        public Forum.ForumRecruitmentDetail[] recruitmentDetails;
        public int availablePages;
        public Forum.PostResponse[] results;
        public int totalResults;
        public bool hasMore;
        public Queries.PagedQuery query;
        public string replacementContinuationToken;
        public bool useTotalResults;
    }
}