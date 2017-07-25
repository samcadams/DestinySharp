using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DestinySharp.Core;
using DestinySharp;

namespace DestinySharp.Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DestinyServiceExplorer _explorer = new DestinyServiceExplorer("token");
            //var hash = _explorer.GetCharacterSummary("Slackr4life24", MembershipType.Xbox).characters[0].characterBase.classHash;
            //ClassDefinition d = _explorer.QueryManifest<ClassDefinition>(hash, DestinyDefinitionType.Class);
            //Console.WriteLine(d);
            //string s = _explorer.ItemList;
            //Console.WriteLine(s);

           // var hash = _explorer.GetCharacterSummary("Slackr4life24", MembershipType.Xbox).characters[0].characterBase.peerView.equipment[3].itemHash;
            string d = _explorer.QueryManifestTest(14239492, DestinyDefinitionType.InventoryBucket);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
