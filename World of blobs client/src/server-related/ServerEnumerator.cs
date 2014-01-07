using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Serialization;
using System.IO;

namespace World_of_blobs_client.src.server_related
{

    class ServerEnumerator
    {
        private string location;
        public ServerEnumerator()
        {
            location = "http://charlieamer.com.ba/worldofblobs/serverlist.xml";
        }
        public List<ServerInfo> enumerateServers()
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(location);
            ServerList l = new ServerList();
            XmlSerializer serializer = new XmlSerializer(typeof(ServerList));
            StringReader reader = new StringReader(content);
            l = serializer.Deserialize(reader) as ServerList;
            return l.list;
        }
    }
}
