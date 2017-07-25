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
        /// <summary> WARNING: WILL NOT WORK FOR DESTINY PLATFORM </summary>
        Blizzard = 4,
    }
}
