namespace DestinySharp.Core.Entities
{
    class ScriptedSkull : ManifestDefinition
    {
        public ulong SkullHash { get; set; }
        public string Identifier { get; set; }
        public string SkullName { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; }
    }
}
