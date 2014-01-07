using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace World_of_blobs_client.src.server_related
{
    public struct ServerInfo
    {
        public string ip { get; set; }
        public string name { get; set; }
        public bool isGame { get; set; }
        public int port { get; set; }
    }
}
