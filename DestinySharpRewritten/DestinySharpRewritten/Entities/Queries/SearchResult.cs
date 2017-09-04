
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Queries
{
    public class SearchResult
    {
        public int totalResults;
        public bool hasMore;
        public Queries.PagedQuery query;
        public string replacementContinuationToken;
        public bool useTotalResults;
    }
}