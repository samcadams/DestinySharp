namespace DestinySharp.Core.Entities
{
    public class EnemyRace : ManifestDefinition
    {
        public ulong RaceHash { get; set; }
        public string Identifier { get; set; }
        public string RaceName { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; }
    }
}
