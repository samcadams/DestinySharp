
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Entities.Characters
{
    public class DestinyCharacterComponent
    {
        public int membershipId;
        public int characterId;
        public string dateLastPlayed;
        public int minutesPlayedThisSession;
        public int minutesPlayedTotal;
        public int light;
        public int raceHash;
        public int genderHash;
        public int classHash;
        public string emblemPath;
        public string emblemBackgroundPath;
        public int emblemHash;
        public int baseCharacterLevel;
        public decimal percentToNextLevel;
    }
}