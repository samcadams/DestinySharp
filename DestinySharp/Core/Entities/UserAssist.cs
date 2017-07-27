using System;
using System.Collections.Generic;
using System.Text;

namespace DestinySharp.Core
{
    public class UserAssist
    {
        public string Name { get; set; }
        public MembershipType MembershipType { get; set; }
        public string MemberShipId { get; set; }
        public List<ulong> CharacterIds { get; set; }
    }
}
