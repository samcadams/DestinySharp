
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Trending
{
    public class TrendingDetail
    {
        public string identifier;
        public Trending.TrendingEntryType entityType;
        public Trending.TrendingEntryNews news;
        public Trending.TrendingEntrySupportArticle support;
        public Trending.TrendingEntryDestinyItem destinyItem;
        public Trending.TrendingEntryDestinyActivity destinyActivity;
        public Trending.TrendingEntryDestinyRitual destinyRitual;
        public Trending.TrendingEntryCommunityCreation creation;
        public Trending.TrendingEntryCommunityStream stream;
    }
}