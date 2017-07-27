using System.Collections.Generic;

namespace DestinySharp.Core.Entities
{
    public class Activity : ManifestDefinition
    {
        public ulong ActivityHash              { get; set; }
        public string ActivityName             { get; set; }
        public string ActivityDescription      { get; set; }
        public string Icon                     { get; set; }
        public string ReleaseIcon              { get; set; }
        public int ReleaseTime                 { get; set; }
        public int ActivityLevel               { get; set; }
        public ulong CompletionFlagHash        { get; set; }
        public int ActivityPower               { get; set; }
        public int MinParty                    { get; set; }
        public int MaxParty                    { get; set; }
        public int MaxPlayers                  { get; set; }
        public ulong DestinationHash           { get; set; }
        public ulong PlaceHash                 { get; set; }
        public ulong ActivityType              { get; set; }
        public int Tier                        { get; set; }    //Needs enum
        public string PcgrImage                { get; set; }
        public List<Reward> Rewards            { get; set; }
        public List<Skull> Skulls              { get; set; }
        public bool isPlaylist                 { get; set; }
        public bool isMatchmade                { get; set; }
    }
}
