using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    public class LegendaryFarming
    {
        public static void Main()
        {
            var junkMaterials = new SortedDictionary<string, int>();
            var legendaryMats = new Dictionary<string, int>();

            legendaryMats["shards"] = 0;
            legendaryMats["fragments"] = 0;
            legendaryMats["motes"] = 0;

            while (true)
            {
                var input = Console.ReadLine()
                    .ToLower()
                    .Split(' ')
                    .ToArray();

                for (int i = 1; i < input.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        if (input[i] == "shards" || input[i] == "fragments" || input[i] == "motes")
                        {
                            legendaryMats[input[i]] += int.Parse(input[i - 1]);
                        }
                        else
                        {
                            if (!junkMaterials.ContainsKey(input[i]))
                            {
                                junkMaterials[input[i]] = 0;
                            }

                            junkMaterials[input[i]] += int.Parse(input[i - 1]);
                        }
                    }

                    if (legendaryMats["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");

                        legendaryMats["shards"] -= 250;
                        PrintResults(legendaryMats, junkMaterials);
                        return;
                    }
                    else if (legendaryMats["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");

                        legendaryMats["fragments"] -= 250;
                        PrintResults(legendaryMats, junkMaterials);
                        return;
                    }
                    if (legendaryMats["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");

                        legendaryMats["motes"] -= 250;
                        PrintResults(legendaryMats, junkMaterials);
                        return;
                    }
                }
            }
        }

        private static void PrintResults(Dictionary<string, int> legendaryMats, SortedDictionary<string, int> junkMaterials)
        {
            foreach (var mat in legendaryMats.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{mat.Key}: {mat.Value}");
            }

            foreach (var mat in junkMaterials)
            {
                Console.WriteLine($"{mat.Key}: {mat.Value}");
            }
        }
    }
}
