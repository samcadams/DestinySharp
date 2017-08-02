namespace DestinySharp.Core.Entities
{
    public class SandboxPerk : ManifestDefinition
    {
        public ulong PerkHash { get; set; }
        public string DisplayName { get; set; }
        public string DisplayDescription { get; set; }
        public string DisplayIcon { get; set; }
        public bool IsDisplayable { get; set; }
        public SandboxPerkGroup PerkGroups { get; set; }
    }

    public class SandboxPerkGroup {
        public int WeaponPerformance { get; set; }
        public int ImpactEffects { get; set; }
        public int GuardianAttributes { get; set; }
        public int LightAbilities { get; set; }
        public int DamageTypes { get; set; }
    }
}
