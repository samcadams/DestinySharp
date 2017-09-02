using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DestinySharp.Core;
using DestinySharp.Core.DataTypes;
using DestinySharp.Core.Entities;

namespace DestinySharp.Testing
{
    [TestClass]
    public class UnitTest1
    {
        readonly DestinyServiceExplorer _explorer = new DestinyServiceExplorer(FullmetalfireflyApikey);
        private const string FullmetalfireflyApikey = "5e7d9ff231914e179c83dc778d4cdeaa";
        private readonly string fullmetalfireflyDisplayName = "Vee_Teh_Neenja";
        private readonly MembershipType fullmetalfireflyMembershipType = MembershipType.PSN;
        private readonly string firesDisplayName = "Slackr4life24";
        private readonly MembershipType firesDisplayDisplayName = MembershipType.Xbox;

        [TestMethod]
        public void ClassDefinitionManifest()
        {
            var hash = _explorer.GetCharacterSummary(fullmetalfireflyDisplayName, fullmetalfireflyMembershipType).characters[0].characterBase.classHash;
            ClassDefinition def = _explorer.SingleQueryManifest<ClassDefinition>(hash, DestinyDefinitionType.Class);
            Console.WriteLine(def.className);
            

            //Hash Exploration
            //var chara = _explorer.GetCharacterSummary("Slackr4life24", MembershipType.Xbox);
            //string d = _explorer.QueryManifestTest(243968262, DestinyDefinitionType.);
            //Console.WriteLine(d);
        }

        //[TestMethod]
        //public void GetWeaponFromManifest()
        //{
        //    var chara = _explorer.GetCharacterSummary("Slackr4life24", MembershipType.Xbox);
        //    string d = _explorer.QueryManifestTest(chara.characters[0].characterBase.characterEquipment.equipment[3].itemHash, DestinyDefinitionType.InventoryItem);
        //    Console.WriteLine(d);
        //}

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
