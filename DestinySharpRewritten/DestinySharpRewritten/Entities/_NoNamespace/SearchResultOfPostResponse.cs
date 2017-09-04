
using System;
using System.Collections.Generic;
using DestinySharp;

namespace DestinySharp
{
    public class SearchResultOfPostResponse
    {
        public Forum.PostResponse[] results;
        public int totalResults;
        public bool hasMore;
        public Queries.PagedQuery query;
        public string replacementContinuationToken;
        public bool useTotalResults;
    }
}