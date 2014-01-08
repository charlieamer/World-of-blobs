using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace World_of_blobs_client.src.server_related
{
    /// <summary>
    /// This class just contains a list of information about various servers available. Used for xml deserialization
    /// </summary>
    [XmlRoot("servers")]
    public class ServerList
    {
        [XmlElement("server")]
        public List<ServerInfo> list { get; set; }
    }
}
