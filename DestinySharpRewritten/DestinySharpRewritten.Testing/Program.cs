using DestinySharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinySharpRewritten.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            BungieClient _client = new BungieClient();
            _client.APIKey = "3797826a7a524ef3b1d4018f78a81165";
            string a = _client.GetDestinyManifest();
            Console.ReadLine();
        }
    }
}
