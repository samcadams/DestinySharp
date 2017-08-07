namespace DestinySharp.Core.Entities
{
    public class DestinyDamageType : ManifestDefinition
    {
        public ulong DamageTypeHash { get; set; }
        public string Identifier { get; set; }
        public string DamageTypeName { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; }
        public string TransparentIconPath { get; set; }
        public bool ShowIcon { get; set; }
        public DamageType EnumValue { get; set; }
    }
}
