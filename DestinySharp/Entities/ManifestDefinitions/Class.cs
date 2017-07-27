using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinySharp.Core.Entities
{
    public class Class : ManifestDefinition
    {
        public ulong ClassHash { get; set; }
        public ClassType ClassType { get; set; }
        public string ClassName { get; set; }
        public string ClassNameMale { get; set; }
        public string ClassNameFemale { get; set; }
        public string ClassIdentifier { get; set; }
        public string MentorVendorIdentifier { get; set; }
    }
}
