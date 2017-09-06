
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
		public ulong raceHash;
		public ulong genderHash;
		public ulong classHash;
		public string emblemPath;
		public string emblemBackgroundPath;
		public ulong emblemHash;
		public int baseCharacterLevel;
		public decimal percentToNextLevel;
	}
}