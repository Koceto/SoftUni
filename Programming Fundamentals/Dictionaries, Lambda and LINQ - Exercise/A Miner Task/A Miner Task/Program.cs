using System;
using System.Collections.Generic;
using System.Linq;

namespace A_Miner_Task
{
    public class AMinerTask
    {
        public static void Main()
        {
            var minerResourses = new Dictionary<string, int>();
            var temp = string.Empty;

            while (true)
            {
                var input = Console.ReadLine();
                string material = string.Empty;
                int ammount = 0;

                if (input.ToLower() == "stop")
                {
                    foreach (var item in minerResourses)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    return;
                }

                if (int.TryParse(input, out ammount))
                {
                    minerResourses[temp] += ammount;
                }
                else
                {
                    material = input;

                    if (!minerResourses.ContainsKey(material))
                    {
                        minerResourses[material] = 0;
                    }
                }
                temp = material;
            }
        }
    }
}
