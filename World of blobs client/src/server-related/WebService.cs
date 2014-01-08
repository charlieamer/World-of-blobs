using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_of_blobs_client.src.server_related
{
    /// <summary>
    /// Information regarding web service.
    /// </summary>
    class WebService : BaseServer
    {
        /// <summary>
        /// Gets content of XML containing list of available servers.
        /// </summary>
        /// <returns>Content of XML containing list of available servers</returns>
        public static string retrieveServerListXML()
        {
            return retrieveString(serverListLocation);
        }
    }
}
