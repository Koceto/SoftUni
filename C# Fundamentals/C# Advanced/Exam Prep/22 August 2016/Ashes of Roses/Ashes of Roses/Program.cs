using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ashes_of_Roses
{
    public class Region
    {
        public string Name { get; set; }
        public List<Color> Colors { get; set; }

        public decimal TotalRoses()
        {
            decimal temp = 0M;

            foreach (var color in Colors)
            {
                temp += color.Ammount;
            }

            return temp;
        }
    }

    public class Color
    {
        public string Name { get; set; }
        public long Ammount { get; set; }
    }

    internal class Program
    {
        public const string Pattern = @"^Grow\s<([A-Z][a-z]*)>\s<([A-Za-z0-9]+)>\s([0-9]+)$";
        public const string EndCommand = "Icarus, Ignite!";

        private static void Main()
        {
            List<Region> regions = new List<Region>();
            Regex regex = new Regex(Pattern);
            string input;

            while ((input = Console.ReadLine()) != EndCommand)
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string regionName = match.Groups[1].ToString();
                    string colorName = match.Groups[2].ToString();
                    long ammount = long.Parse(match.Groups[3].ToString());

                    Region currentRegion = new Region();
                    Color currentColor = new Color
                    {
                        Name = colorName,
                        Ammount = ammount
                    };

                    currentRegion.Name = regionName;
                    currentRegion.Colors = new List<Color> { currentColor };

                    Region regionToModify = regions.FirstOrDefault(r => r.Name == currentRegion.Name); // Grabs the existing Region and return null if none

                    if (regionToModify == null) // Check if does NOT Region exists
                    {
                        regions.Add(currentRegion); // If it doesn't exist, adds it
                    }
                    else
                    {
                        Color colorToModify = regionToModify.Colors.FirstOrDefault(c => c.Name == currentColor.Name); // Grab the current color and returns null if none

                        if (colorToModify == null) // Check if the existing Region contains the new color
                        {
                            if (currentColor.Ammount != 0)
                            {
                                regionToModify.Colors.Add(currentColor);
                            }
                        }
                        else // If it doesn't exist, adds the new color to the existing Region
                        {
                            colorToModify.Ammount += ammount;
                        }
                    }
                }
            }

            foreach (var region in regions.OrderByDescending(r => r.TotalRoses()).ThenBy(r => r.Name))
            {
                Console.WriteLine(region.Name);

                foreach (var color in region.Colors.OrderBy(c => c.Ammount).ThenBy(c => c.Name))
                {
                    Console.WriteLine($"*--{color.Name} | {color.Ammount}");
                }
            }
        }
    }
}