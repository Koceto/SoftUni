using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Cubic_Assault
{
    public class Region
    {
        public string Name { get; set; }

        public long Black { get; set; }

        public long Red { get; set; }

        public long Green { get; set; }
    }

    internal class Program
    {
        public const string EndCommand = "Count em all";
        public const int MaxMeteors = 1000000;

        private static void Main()
        {
            string input;
            List<Region> regions = new List<Region>();

            while ((input = Console.ReadLine().Trim()) != EndCommand)
            {
                var data = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string regionName = data[0];
                string meteorName = data[1];
                long meteorCount = long.Parse(data[2]);

                Region currentRegion = new Region()
                {
                    Name = regionName
                };
                Region regionToModify = regions.FirstOrDefault(r => r.Name == regionName);

                AddMeteors(currentRegion, meteorName, meteorCount);

                if (regionToModify != null)
                {
                    AddMeteors(regionToModify, meteorName, meteorCount);
                }
                else
                {
                    regions.Add(currentRegion);
                }
            }

            foreach (var region in regions.OrderByDescending(r => r.Black).ThenBy(r => r.Name.Length).ThenBy(r => r.Name))
            {
                Console.WriteLine($"{region.Name}");

                var stupidPointlessVariable = new Dictionary<string, long>();
                stupidPointlessVariable.Add("Red", region.Red);
                stupidPointlessVariable.Add("Black", region.Black);
                stupidPointlessVariable.Add("Green", region.Green);

                foreach (var kvp in stupidPointlessVariable.OrderByDescending(m => m.Value).ThenBy(m => m.Key))
                {
                    Console.WriteLine($"-> {kvp.Key} : {kvp.Value}");
                }
            }
        }

        private static void AddMeteors(Region currentRegion, string meteorName, long meteorCount)
        {
            switch (meteorName.ToLower())
            {
                case "black":
                    currentRegion.Black += meteorCount;
                    CheckOverFlow(currentRegion);
                    break;

                case "red":
                    currentRegion.Red += meteorCount;
                    CheckOverFlow(currentRegion);
                    break;

                case "green":
                    currentRegion.Green += meteorCount;
                    CheckOverFlow(currentRegion);
                    break;
            }
        }

        private static void CheckOverFlow(Region currentRegion)
        {
            while (currentRegion.Green >= MaxMeteors)
            {
                currentRegion.Green -= MaxMeteors;
                currentRegion.Red += 1;
            }

            while (currentRegion.Red >= MaxMeteors)
            {
                currentRegion.Red -= MaxMeteors;
                currentRegion.Black += 1;
            }
        }
    }
}