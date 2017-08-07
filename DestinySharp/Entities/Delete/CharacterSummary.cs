using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using DestinySharp.Core.DataTypes;

namespace DestinySharp.Core.DataTypes
{
    /// <summary>
    /// CharacterSummary request adata. Contains an array of characters and multiple inventory items.
    /// </summary>
    public class CharacterSummaryData
    {
        public string membershipId { get; set; }
        public int membershipType { get; set; }
        public IList<Character> characters { get; set; }
        public Inventory inventory { get; set; }
        public int grimoireScore { get; set; }
        public int versions { get; set; }
    }

    /// <summary>
    /// Destiny Character Customization
    /// </summary>
    public class Customization
    {
        public ulong personality { get; set; }
        public ulong face { get; set; }
        public ulong skinColor { get; set; }
        public int lipColor { get; set; }
        public ulong eyeColor { get; set; }
        public long hairColor { get; set; }
        public ulong featureColor { get; set; }
        public ulong decalColor { get; set; }
        public bool wearHelmet { get; set; }
        public int hairIndex { get; set; }
        public int featureIndex { get; set; }
        public int decalIndex { get; set; }
    }

    /// <summary>
    /// Needs documentation
    /// </summary>
    public class Dye
    {
        public ulong channelHash { get; set; }
        public ulong dyeHash { get; set; }
    }

    /// <summary>
    /// Hashed equipment inside of "PeerView"
    /// </summary>
    public class HashedEquipment
    {
        public ulong itemHash { get; set; }
        public IList<Dye> dyes { get; set; }
    }

    /// <summary>
    /// Stores an array of character equipment. All hashed, must query Manifest with "InventoryItem" as type.
    /// </summary>
    public class PeerView
    {
        public IList<HashedEquipment> equipment { get; set; }
    }

    /// <summary>
    /// The main character base.
    /// </summary>
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
        public ulong genderHash { get; set; }
        public ulong classHash { get; set; }
        public int currentActivityHash { get; set; }
        public int lastCompletedStoryHash { get; set; }
        public Stats stats { get; set; }
        public Customization customization { get; set; }
        public int grimoireScore { get; set; }
        [JsonProperty("peerView")]
        public PeerView characterEquipment { get; set; }
        public int genderType { get; set; }
        public int classType { get; set; }
        public ulong buildStatGroupHash { get; set; }
    }

    /// <summary>
    /// XP level progression. Needs proper testing
    /// </summary>
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

    /// <summary>
    /// Character object, similiar to the character base but with less information.
    /// </summary>
    public class Character
    {
        public CharacterBase characterBase { get; set; }
        public LevelProgression levelProgression { get; set; }
        public string emblemPath { get; set; }
        public string backgroundPath { get; set; }
        public ulong emblemHash { get; set; }
        public int characterLevel { get; set; }
        public int baseCharacterLevel { get; set; }
        public bool isPrestigeLevel { get; set; }
        public double percentToNextLevel { get; set; }
    }

    /// <summary>
    /// Hashed currency inside your character
    /// </summary>
    public class HashedCurrency
    {
        public ulong itemHash { get; set; }
        public int value { get; set; }
    }

    /// <summary>
    /// Player inventory. Testing up to now always has "items" empty.
    /// </summary>
    public class Inventory
    {
        public IList<object> items { get; set; }
        public IList<HashedCurrency> currencies { get; set; }
    }


}

