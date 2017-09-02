using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DestinySharp.Core;

namespace DestinySharp.Console
{
    class DestinySharpProgram
    {
        private static readonly string Fullmetalfireflyapikey = "";
        private static DestinyServiceExplorer _service;

        private static string MembershipId { get; set; }

        private static MembershipType MembershipType { get; set; }

        private static string DisplayName { get; set; }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello Guardian! ");
            // FULLMETALFIREFLY TEST VARIABLES
            DisplayName = "vee_teh_neenja";
            MembershipType = MembershipType.PSN;
            //MembershipId = "4611686018434269858";

            _service = new DestinyServiceExplorer(Fullmetalfireflyapikey);

            // testing
            var results = _service.SearchDestinyPlayer(DisplayName, MembershipType);

            // display
            System.Console.WriteLine("Results: {0}", results.ToString());

            System.Console.WriteLine("[ E N D ]");
            System.Console.ReadLine();
        }
    }
}
