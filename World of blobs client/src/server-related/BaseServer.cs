using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using World_of_blobs_client.src.exceptions;

namespace World_of_blobs_client.src.server_related
{
    class BaseServer
    {
        /// <summary>
        /// Location of web service.
        /// </summary>
        // TODO Change this to appropriate value after migration
        protected static string location = "http://charlieamer.com.ba/worldofblobs";

        /// <summary>
        /// Location of xml containing all servers available
        /// </summary>
        protected static string serverListLocation = location + "/serverlist.xml";

        /// <summary>
        /// Total number of requests
        /// </summary>
        public static int numberOfRequests;

        /// <summary>
        /// Total number of dropped requests (usually timeout)
        /// </summary>
        public static int numberOfDroppedRequests;

        /// <summary>
        /// Last ping value
        /// </summary>
        public static long lastPing;

        /// <summary>
        /// Used for calculating average ping
        /// </summary>
        protected static long totalPing;

        /// <summary>
        /// Average ping of every request
        /// </summary>
        public static long averagePing;

        /// <summary>
        /// Number of retries before it is considered that service is unreachable
        /// </summary>
        public const int numberOfRetries = 3;

        /// <summary>
        /// Stopwatch for measuring time of service response
        /// </summary>
        protected static Stopwatch stopwatch = new Stopwatch();

        /// <summary>
        /// Start measuring time of request
        /// </summary>
        protected static void startRequest()
        {
            Console.Write("Starting webservice request ... ");
            stopwatch.Restart();
        }

        /// <summary>
        /// Stop measuring time and log some statistics
        /// </summary>
        protected static void stopRequest()
        {
            numberOfRequests++;
            stopwatch.Stop();
            lastPing = stopwatch.ElapsedMilliseconds;
            totalPing += lastPing;
            averagePing = totalPing / numberOfRequests;
            Console.WriteLine("Done in " + lastPing + "ms");
        }

        /// <summary>
        /// Retrieves something from internet and returns it as string. It tries until it succeeds, max <value>numberOfRetries</value> times
        /// </summary>
        /// <param name="url">URL for retrieval</param>
        /// <returns>Content found on given URL</returns>
        protected static string retrieveString(string url)
        {
            int triesLeft = numberOfRetries;
            while (triesLeft > 0)
            {
                try
                {
                    startRequest();
                    triesLeft--;
                    WebClient client = new WebClient();
                    string toRet = client.DownloadString(url);
                    stopRequest();
                    return toRet;
                }
                catch (Exception ex)
                {
                    // TODO log what kind of exception happened
                    numberOfDroppedRequests++;
                    stopRequest();
                }
            }
            throw new RetryLimitReachedException("Reached retry limit of " + numberOfRetries + " times.");
        }
    }
}
