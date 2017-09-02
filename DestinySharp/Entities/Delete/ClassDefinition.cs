using DestinySharp.Core.Entities;

namespace DestinySharp.Core.DataTypes
{
    public class ClassDefinitionData
    {
        public ulong requestedId { get; set; }
        public ClassDefinition classDefinition { get; set; }
    }

    public class ClassDefinition
    {
        public ulong classHash { get; set; }
        public DestinyClass classType { get; set; }
        public string className { get; set; }
        public string classNameMale { get; set; }
        public string classNameFemale { get; set; }
        public string classIdentifer { get; set; }
        public string mentorVendorIdentifier { get; set; }
        public ulong hash { get; set; }
        public int index { get; set; }
        public bool redacted { get; set; }
    }
}
