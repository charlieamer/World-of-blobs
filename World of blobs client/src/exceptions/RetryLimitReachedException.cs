using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_of_blobs_client.src.exceptions
{
    class RetryLimitReachedException : Exception
    {
        public RetryLimitReachedException(string text) : base(text)
        {
        }
    }
}
