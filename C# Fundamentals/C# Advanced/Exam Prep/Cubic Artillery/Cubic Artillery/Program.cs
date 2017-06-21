using System;
using System.Collections.Generic;

namespace Cubic_Artillery
{
    internal class Bunker
    {
        public string Name { get; set; }
        public Queue<int> Weapons { get; set; }
        public int FilledCapacity { get; set; }
    }

    internal class Program
    {
        private const string EndCommand = "Bunker Revision";

        private static void Main()
        {
            int capacity = int.Parse(Console.ReadLine());
            var bunkers = new List<Bunker>();
            string input;

            while ((input = Console.ReadLine()) != EndCommand)
            {
                foreach (var currentBunker in input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)) // For Each Input Line
                {
                    int weapon;

                    if (int.TryParse(currentBunker, out weapon)) // If input is digit
                    {
                        bool isStored = false;

                        while (!isStored) // Tries to store items untill done
                        {
                            var firstBunker = bunkers[0];
                            bool canBeStored = firstBunker.FilledCapacity + weapon <= capacity; // Check if there is enough free space 

                            if (canBeStored) // Fill Bunker
                            {
                                firstBunker.FilledCapacity += weapon;
                                firstBunker.Weapons.Enqueue(weapon);
                                isStored = true;
                            }
                            else if (!canBeStored) // Overflow
                            {
                                if (bunkers.Count == 1) // Check if there is only one bunker
                                {
                                    if (weapon <= capacity) // Check if weapon can be stored in bunker
                                    {
                                        while (firstBunker.FilledCapacity + weapon > capacity)
                                        {
                                            firstBunker.FilledCapacity -= firstBunker.Weapons.Dequeue();
                                        }

                                        firstBunker.Weapons.Enqueue(weapon);
                                        firstBunker.FilledCapacity += weapon;
                                        isStored = true;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    PrintBunker(bunkers);
                                }
                            }
                        }
                    }
                    else
                    {
                        bunkers.Add(new Bunker()
                        {
                            Name = currentBunker,
                            Weapons = new Queue<int>(),
                            FilledCapacity = 0
                        });
                    }
                }
            }
        }

        private static void PrintBunker(List<Bunker> bunkers)
        {
            var firstBunker = bunkers[0];

            if (firstBunker.Weapons.Count != 0) // Check if bunker has any weapons
            {
                Console.WriteLine($"{firstBunker.Name} -> {string.Join(", ", firstBunker.Weapons)}");
            }
            else
            {
                Console.WriteLine($"{firstBunker.Name} -> Empty");
            }

            bunkers.Remove(firstBunker);
        }
    }
}