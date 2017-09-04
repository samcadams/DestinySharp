
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Requests.Actions
{
    public class DestinyItemSetActionRequest
    {
        public ulong[] itemIds;
        public int characterId;
        public DestinySharp.BungieMembershipType membershipType;
    }
}