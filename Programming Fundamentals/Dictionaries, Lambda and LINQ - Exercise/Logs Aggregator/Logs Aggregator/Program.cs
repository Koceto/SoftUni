using System;
using System.Collections.Generic;
using System.Linq;

namespace Logs_Aggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var users = new SortedDictionary<string, Logs>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ');
                string ip = input[0];
                string userName = input[1];
                int duration = int.Parse(input[2]);

                if (!users.ContainsKey(userName))
                {
                    users[userName] = new Logs
                    {
                        IpAndDuration = new SortedDictionary<string, int>()
                    };
                }
                if (!users[userName].IpAndDuration.ContainsKey(ip))
                {
                    users[userName].IpAndDuration[ip] = 0;
                }

                users[userName].IpAndDuration[ip] += duration;
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}: {user.Value.TotalTime()} [{PrintKeys(user)}]");
            }
        }

        public static object PrintKeys(KeyValuePair<string, Logs> user)
        {
            string temp = user.Value.IpAndDuration.Keys.ToArray()[0];

            foreach (var ip in user.Value.IpAndDuration.Keys.ToArray().Skip(1))
            {
                temp = temp + ", " + ip;
            }
            return temp;
        }
    }
}
