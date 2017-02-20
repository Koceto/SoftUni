using System;
using System.Collections.Generic;
using System.Linq;

namespace User_Logs
{
    public class UserLogs
    {
        public static void Main()
        {
            var logs = new SortedDictionary<string, IpLogs>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(' ');

                if (input[0].ToLower() == "end")
                {
                    foreach (var user in logs)
                    {
                        Console.WriteLine(user.Key + ":");
                        foreach (var ipLog in user.Value.UserIpList)
                        {
                            Console.Write("{0} => {1}{2}",
                                ipLog.Key,
                                ipLog.Value,
                                ipLog.Key == logs[user.Key].UserIpList.Keys.Last() ?
                                new string('.', 1) :
                                new string(',', 1) + new string(' ', 1));
                    }
                    Console.WriteLine();
                }
                return;
            }

            var Ip = input[0]
                .Split('=')
                .Skip(1)
                .Take(1)
                .ToArray();
            var userName = input[2]
                .Split('=')
                .Skip(1)
                .Take(1)
                .ToArray();

            if (!logs.ContainsKey(userName[0]))
            {
                logs[userName[0]] = new IpLogs
                {
                    UserIpList = new Dictionary<string, int>()
                };
                logs[userName[0]].UserIpList[Ip[0]] = 1;

            }
            else
            {
                if (!logs[userName[0]].UserIpList.ContainsKey(Ip[0]))
                {
                    logs[userName[0]].UserIpList[Ip[0]] = 1;
                }
                else
                {
                    logs[userName[0]].UserIpList[Ip[0]] += 1;
                }
            }
        }
    }
}
}
