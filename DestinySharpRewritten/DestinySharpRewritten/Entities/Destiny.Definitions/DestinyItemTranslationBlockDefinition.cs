
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Definitions
{
    public class DestinyItemTranslationBlockDefinition
    {
        public string weaponPatternIdentifier;
        public int weaponPatternHash;
        public Destiny.DyeReference[] defaultDyes;
        public Destiny.DyeReference[] lockedDyes;
        public Destiny.DyeReference[] customDyes;
        public Destiny.Definitions.DestinyGearArtArrangementReference[] arrangements;
        public bool hasGeometry;
    }
}