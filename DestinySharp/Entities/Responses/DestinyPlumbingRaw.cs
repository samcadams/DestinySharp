using Newtonsoft.Json;
using System.Collections.Generic;

namespace DestinySharp.Core.DataTypes
{
    /// <summary>
    /// Raw response object from destiny.plumbing
    /// </summary>
    public class DestinyPlumbingRaw
    {
        /// <summary> French </summary>
        public DestinyPlumbingRawObjects fr { get; set; }
        /// <summary> English </summary>
        public DestinyPlumbingRawObjects en { get; set; }
        /// <summary> Espanol </summary>
        public DestinyPlumbingRawObjects es { get; set; }
        /// <summary> Deutch </summary>
        public DestinyPlumbingRawObjects de { get; set; }
        /// <summary> Italian </summary>
        public DestinyPlumbingRawObjects it { get; set; }
        /// <summary> Japanese </summary>
        public DestinyPlumbingRawObjects ja { get; set; }
        /// <summary> Brazillian Portugese </summary>
        [JsonProperty("pt-br")]
        public Dictionary<string, DestinyPlumbingRawObjects> pt_br { get; set; }
        public string bungieManifestVersion { get; set; }
    }

    public class DestinyPlumbingRawObjects
    {
        public Dictionary<string, string> raw { get; set; }
        public Dictionary<string, string> items { get; set; }
        public Dictionary<string, string> collections { get; set; }
    }
}
