using System;
using System.Collections.Generic;

namespace A_Miner_s_Task
{
    public static class StartUp
    {
        public static void Main()
        {
            var recources = new Dictionary<string, int>();

            while (true)
            {
                var material = Console.ReadLine();

                if (material.ToLower() == "stop")
                {
                    break;
                }
                var ammount = int.Parse(Console.ReadLine());

                if (recources.ContainsKey(material))
                {
                    recources[material] += ammount;
                }
                else
                {
                    recources.Add(material, ammount);
                }
            }

            foreach (var recource in recources)
            {
                Console.WriteLine($"{recource.Key} -> {recource.Value}");
            }
        }
    }
}