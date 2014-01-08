using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace World_of_blobs_client.src.server_related
{
    /// <summary>
    /// This class is giving information about a server like ip, port, name, etc.
    /// </summary>
    public struct ServerInfo
    {
        /// <summary>
        /// IP address of the server
        /// </summary>
        public string ip { get; set; }

        /// <summary>
        /// Name of the server
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Is this server a game server (true) or chat server (false)
        /// </summary>
        public bool isGame { get; set; }

        /// <summary>
        /// Server port number
        /// </summary>
        public int port { get; set; }
    }
}
