
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Queries
{
    public class PagedQuery
    {
		public int itemsPerPage;
		public int currentPage;
		public string requestContinuationToken;
	}
}