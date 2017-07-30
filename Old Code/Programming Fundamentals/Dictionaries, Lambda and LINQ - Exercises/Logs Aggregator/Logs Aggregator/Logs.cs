using System.Collections.Generic;

namespace Logs_Aggregator
{
    public class Logs
    {
        public SortedDictionary<string, int> IpAndDuration { get; set; }

        public int TotalTime()
        {
            var temp = 0;

            foreach (var ip in IpAndDuration)
            {
                temp += ip.Value;
            }

            return temp;
        }
    }
}
