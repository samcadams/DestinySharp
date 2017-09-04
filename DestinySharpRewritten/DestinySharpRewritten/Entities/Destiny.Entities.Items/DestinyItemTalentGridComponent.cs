
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Entities.Items
{
    public class DestinyItemTalentGridComponent
    {
        public int talentGridHash;
        public Destiny.DestinyTalentNode[] nodes;
        public bool isGridComplete;
    }
}