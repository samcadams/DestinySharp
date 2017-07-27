using DestinySharp.Core.DataTypes;

namespace DestinySharp.Core.Entities
{
    public class Gender : ManifestDefinition
    {
        public ulong GenderHash { get; set; }
        public GenderType GenderType { get; set; }
        public string GenderName { get; set; }
        public string GenderDescription { get; set; }
    }
}
