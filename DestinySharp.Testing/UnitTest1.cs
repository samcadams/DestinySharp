using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DestinySharp.Core;
using DestinySharp.Core.DataTypes;

namespace DestinySharp.Testing
{
    [TestClass]
    public class UnitTest1
    {
        DestinyServiceExplorer _explorer = new DestinyServiceExplorer("token");
    
        [TestMethod]
        public void ClassDefinitionManifest()
        {
            var hash = _explorer.GetCharacterSummary("Slackr4life24", MembershipType.Xbox).characters[0].characterBase.classHash;
            ClassDefinition def = _explorer.QueryManifest<ClassDefinition>(hash, DestinyDefinitionType.Class);
            Console.WriteLine(def.className);
            

            //Hash Exploration
            //var chara = _explorer.GetCharacterSummary("Slackr4life24", MembershipType.Xbox);
            //string d = _explorer.QueryManifestTest(243968262, DestinyDefinitionType.);
            //Console.WriteLine(d);
        }

        [TestMethod]
        public void GetWeaponFromManifest()
        {
            var chara = _explorer.GetCharacterSummary("Slackr4life24", MembershipType.Xbox);
            string d = _explorer.QueryManifestTest(chara.characters[0].characterBase.characterEquipment.equipment[3].itemHash, DestinyDefinitionType.InventoryItem);
            Console.WriteLine(d);
        }

        [TestMethod]
        public void GetActivityStats()
        {
            var chara = _explorer.GetCharacterSummary("Slackr4life24", MembershipType.Xbox);
            var stats = _explorer.GetActivityHistoryStats(chara.characters[0].characterBase.membershipId, chara.characters[0].characterBase.characterId, MembershipType.Xbox, DestinyActivityMode.Story);
            Console.WriteLine(stats.activities[2].activityDetails.mode);
        }

        [TestMethod]
        public void GetAdviserInfo()
        {
            var chara = _explorer.GetCharacterSummary("Slackr4life24", MembershipType.Xbox);
            var adviserinfo = _explorer.GetAdvisorData(chara.membershipId, MembershipType.Xbox, definitions: true);
            Console.WriteLine(adviserinfo);
        }

    }
}
