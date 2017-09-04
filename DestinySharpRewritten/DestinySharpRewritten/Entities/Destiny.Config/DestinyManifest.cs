
using System;
using System.Collections.Generic;
using DestinySharp;

namespace Destiny.Config
{
    public class DestinyManifest
    {
        public string version;
        public string mobileAssetContentPath;
        public Destiny.Config.GearAssetDataBaseDefinition[] mobileGearAssetDataBases;
        public string mobileClanBannerDatabasePath;
    }
}