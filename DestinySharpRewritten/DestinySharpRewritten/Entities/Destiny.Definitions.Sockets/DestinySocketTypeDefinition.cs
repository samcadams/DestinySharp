
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions.Sockets
{
    public class DestinySocketTypeDefinition
    {
        public Destiny.Definitions.Sockets.DestinyPlugWhitelistEntryDefinition[] plugWhitelist;
        public int socketCategoryHash;
        public Destiny.DestinySocketVisibility visibility;
        public int hash;
        public int index;
        public bool redacted;
    }
}