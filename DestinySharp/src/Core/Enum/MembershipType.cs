using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinySharp.Core
{
    /// <summary>
    /// Membershiptype that Bungie api takes
    /// </summary>
    public enum MembershipType
    {
        /// <summary> Used for xbox gamers </summary>
        Xbox = 1,
        /// <summary> Used for psn gamers </summary>
        PSN = 2,
        /// <summary> WARNING: NO IDEA IF THIS WORKS </summary>
        Blizzard = 4,
    }
}
