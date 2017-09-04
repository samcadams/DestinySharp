
using System;
using System.Collections.Generic;
using DestinySharp;

namespace DestinySharp
{
    public class SearchResultOfCommunityLiveStatus
    {
        public Community.CommunityLiveStatus[] results;
        public int totalResults;
        public bool hasMore;
        public Queries.PagedQuery query;
        public string replacementContinuationToken;
        public bool useTotalResults;
    }
}