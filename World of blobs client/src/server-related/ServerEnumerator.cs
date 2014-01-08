using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using World_of_blobs_client.src.server_related;

namespace World_of_blobs_client.src.server_related
{
    /// <summary>
    /// Enumerates list of all available servers to connect to (both chat and game servers)
    /// </summary>
    class ServerEnumerator
    {
        /// <summary>
        /// Enumerates all servers available
        /// </summary>
        /// <returns>List of information regarding each server</returns>
        public List<ServerInfo> enumerateServers()
        {
            ServerList l = new ServerList();
            XmlSerializer serializer = new XmlSerializer(typeof(ServerList));
            StringReader reader = new StringReader(WebService.retrieveServerListXML());
            l = serializer.Deserialize(reader) as ServerList;
            return l.list;
        }
    }
}
