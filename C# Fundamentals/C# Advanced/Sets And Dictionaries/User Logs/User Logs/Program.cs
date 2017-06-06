namespace User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IPAndCount
    {
        public string IP { get; set; }

        public int TimesUsed { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            var logs = new SortedDictionary<string, List<IPAndCount>>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ');

                if (input.First().ToLower() == "end")
                {
                    break;
                }

                var ip = input.First().Split('=').Last();
                var user = input.Last().Split('=').Last();

                if (!logs.ContainsKey(user))
                {
                    logs.Add(user, new List<IPAndCount>()
                    {
                        new IPAndCount()
                        {
                            IP = ip,
                            TimesUsed = 1
                        }
                    });
                }
                else
                {
                    if (!logs[user].Exists(i => i.IP == ip))
                    {
                        logs[user].Add(new IPAndCount()
                        {
                            IP = ip,
                            TimesUsed = 1
                        });
                    }
                    else
                    {
                        logs[user].Find(i => i.IP == ip).TimesUsed++;
                    }
                }
            }

            foreach (var log in logs)
            {
                Console.WriteLine(log.Key + ": ");
                
                for (int i = 0; i < log.Value.Count; i++)
                {
                    var currLog = log.Value[i];
                    var pointLess = i < log.Value.Count - 1 ? ", " : ".\n";

                    Console.Write($"{currLog.IP} => {currLog.TimesUsed}" + pointLess);
                }
            }
        }
    }
}