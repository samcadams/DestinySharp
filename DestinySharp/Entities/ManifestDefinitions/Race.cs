namespace DestinySharp.Core.Entities
{ 
    public class Race : ManifestDefinition
    {
        public ulong RaceHash { get; set; }
        public RaceType RaceType { get; set; }
        public string RaceName { get; set; }
        public string RaceNameMale { get; set; }
        public string RaceNameFemale { get; set; }
        public string RaceDescription { get; set; }
    }
}
