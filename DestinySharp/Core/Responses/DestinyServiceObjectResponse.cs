using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinySharp.Core
{
    public class DestinyServiceObjectResponse
    {
        public Response Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public MessageData MessageData { get; set; }
    }

    #region Stats
    public class STATDEFENSE
    {
        public object statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATINTELLECT
    {
        public int statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATDISCIPLINE
    {
        public int statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATSTRENGTH
    {
        public object statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATLIGHT
    {
        public object statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATARMOR
    {
        public int statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATAGILITY
    {
        public object statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATRECOVERY
    {
        public int statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }

    public class STATOPTICS
    {
        public object statHash { get; set; }
        public int value { get; set; }
        public int maximumValue { get; set; }
    }
#endregion

    public class Stats
    {
        public STATDEFENSE STAT_DEFENSE { get; set; }
        public STATINTELLECT STAT_INTELLECT { get; set; }
        public STATDISCIPLINE STAT_DISCIPLINE { get; set; }
        public STATSTRENGTH STAT_STRENGTH { get; set; }
        public STATLIGHT STAT_LIGHT { get; set; }
        public STATARMOR STAT_ARMOR { get; set; }
        public STATAGILITY STAT_AGILITY { get; set; }
        public STATRECOVERY STAT_RECOVERY { get; set; }
        public STATOPTICS STAT_OPTICS { get; set; }
    }

    public class Customization
    {
        public object personality { get; set; }
        public object face { get; set; }
        public object skinColor { get; set; }
        public int lipColor { get; set; }
        public object eyeColor { get; set; }
        public long hairColor { get; set; }
        public object featureColor { get; set; }
        public object decalColor { get; set; }
        public bool wearHelmet { get; set; }
        public int hairIndex { get; set; }
        public int featureIndex { get; set; }
        public int decalIndex { get; set; }
    }

    public class Dye
    {
        public object channelHash { get; set; }
        public object dyeHash { get; set; }
    }

    public class Equipment
    {
        public object itemHash { get; set; }
        public IList<Dye> dyes { get; set; }
    }

    public class PeerView
    {
        public IList<Equipment> equipment { get; set; }
    }

    public class CharacterBase
    {
        public string membershipId { get; set; }
        public int membershipType { get; set; }
        public string characterId { get; set; }
        public DateTime dateLastPlayed { get; set; }
        public string minutesPlayedThisSession { get; set; }
        public string minutesPlayedTotal { get; set; }
        public int powerLevel { get; set; }
        public long raceHash { get; set; }
        public object genderHash { get; set; }
        public object classHash { get; set; }
        public int currentActivityHash { get; set; }
        public int lastCompletedStoryHash { get; set; }
        public Stats stats { get; set; }
        public Customization customization { get; set; }
        public int grimoireScore { get; set; }
        public PeerView peerView { get; set; }
        public int genderType { get; set; }
        public int classType { get; set; }
        public object buildStatGroupHash { get; set; }
    }

    public class LevelProgression
    {
        public int dailyProgress { get; set; }
        public int weeklyProgress { get; set; }
        public int currentProgress { get; set; }
        public int level { get; set; }
        public int step { get; set; }
        public int progressToNextLevel { get; set; }
        public int nextLevelAt { get; set; }
        public int progressionHash { get; set; }
    }

    public class Character
    {
        public CharacterBase characterBase { get; set; }
        public LevelProgression levelProgression { get; set; }
        public string emblemPath { get; set; }
        public string backgroundPath { get; set; }
        public object emblemHash { get; set; }
        public int characterLevel { get; set; }
        public int baseCharacterLevel { get; set; }
        public bool isPrestigeLevel { get; set; }
        public double percentToNextLevel { get; set; }
    }

    public class Currency
    {
        public object itemHash { get; set; }
        public int value { get; set; }
    }

    public class Inventory
    {
        public IList<object> items { get; set; }
        public IList<Currency> currencies { get; set; }
    }

    public class Data
    {
        public string membershipId { get; set; }
        public int membershipType { get; set; }
        public IList<Character> characters { get; set; }
        public Inventory inventory { get; set; }
        public int grimoireScore { get; set; }
        public int versions { get; set; }
    }

    public class Response
    {
        public Data data { get; set; }
    }

    public class MessageData
    {
        dynamic data { get; set; }
    }

}
