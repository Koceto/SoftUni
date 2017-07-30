﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Srubsko_Unleashed
{
    public class Srubsko
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var command = new List<string>();

            while (input.ToLower() != "end")
            {
                command = input
                    .Split(' ')
                    .ToList();

                if (command.Count >= 4)
                {
                    CollectData(command);
                }

                input = Console.ReadLine();

            }

            PrintResult();
        }

        public static Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();

        public static void CollectData(List<string> command)
        {
            int ticketPrice = 0;
            int ticketCount = 0;
            int venueIndex = 0;
            string venue = string.Empty;
            string singer = string.Empty;

            if (int.TryParse(command.Last(), out ticketCount) && int.TryParse(command[command.Count - 2], out ticketPrice))
            {
                venueIndex = command.FindIndex(x => x.StartsWith("@"));

                if (venueIndex < 0)
                {
                    return;
                }

                ticketCount = int.Parse(command.Last());
                command.RemoveAt(command.Count - 1);
                ticketPrice = int.Parse(command.Last());
                command.RemoveAt(command.Count - 1);

                var temp = command
                    .GetRange(venueIndex, command.Count - venueIndex)
                    .ToArray();
                var temp2 = command
                    .GetRange(0, command.Count - temp.Length)
                    .ToArray();

                venue = string.Join(" ", temp);
                venue = venue.Remove(0, 1);
                singer = string.Join(" ", temp2);

                if (!data.ContainsKey(venue))
                {
                    data[venue] = new Dictionary<string, long>();
                }

                if (!data[venue].ContainsKey(singer))
                {
                    data[venue].Add(singer, 0);
                }

                data[venue][singer] += (long)ticketCount * ticketPrice;
            }
        }

        public static void PrintResult()
        {
            foreach (var venue in data)
            {
                Console.WriteLine($"{venue.Key}");

                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}