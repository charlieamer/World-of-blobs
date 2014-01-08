using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using World_of_blobs_client.src.server_related;

namespace World_of_blobs_client
{
    class Client
    {
        static void Main(string[] args)
        {
            ServerEnumerator enumerator = new ServerEnumerator();
            List<ServerInfo> infos = enumerator.enumerateServers();
            foreach (ServerInfo info in infos)
            {
                Console.Write("------------------\nIp: " + info.ip + ":" + info.port + "\nName: " + info.name + "\nIs game server: " + info.isGame + "\n");
            }
            Console.Write("\nPress a key to exit");
            Console.ReadKey();
        }
    }
}
