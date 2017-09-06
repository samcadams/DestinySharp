using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinySharp
{
    public partial class BungieClient
    {
        public string APIKey;

        RestClient _client = new RestClient("http://www.bungie.net/Platform");
    }
}
