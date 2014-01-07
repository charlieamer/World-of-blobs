using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace World_of_blobs_client.src.server_related
{
    [Serializable]
    [XmlRoot("servers")]
    public class ServerList
    {
        [XmlElement("server")]
        public List<ServerInfo> list { get; set; }
    }
}
