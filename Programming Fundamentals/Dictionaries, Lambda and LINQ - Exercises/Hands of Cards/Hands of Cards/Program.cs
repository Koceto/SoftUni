using System;
using System.Collections.Generic;
using System.Linq;

namespace Hands_of_Cards
{
    public class HandsofCards
    {
        public static void Main()
        {
            var scoreCounter = new Dictionary<string, int>();
            var cards = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string Name = string.Empty;

                Name = input[0];

                if (Name.ToLower() == "joker")
                {
                    foreach (var player in cards.Keys)
                    {
                        foreach (var item in cards[player].Distinct())
                        {
                            var cardPower = item.ToCharArray();
                            int power = 0;
                            char multiplierPower = cardPower.Last();
                            int multiplier = 0;

                            if (cardPower[0] == '1' && cardPower[1] == '0')
                            {
                                power = 10;
                            }
                            else if (cardPower[0] == 'J')
                            {
                                power = 11;
                            }
                            else if (cardPower[0] == 'Q')
                            {
                                power = 12;
                            }
                            else if (cardPower[0] == 'K')
                            {
                                power = 13;
                            }
                            else if (cardPower[0] == 'A')
                            {
                                power = 14;
                            }
                            else
                            {
                                power = int.Parse(cardPower[0].ToString());
                            }

                            if (multiplierPower == 'S')
                            {
                                multiplier = 4;
                            }
                            else if (multiplierPower == 'H')
                            {
                                multiplier = 3;
                            }
                            else if (multiplierPower == 'D')
                            {
                                multiplier = 2;
                            }
                            else if (multiplierPower == 'C')
                            {
                                multiplier = 1;
                            }

                            if (!scoreCounter.ContainsKey(player))
                            {
                                scoreCounter[player] = 0;
                            }
                            scoreCounter[player] += power * multiplier;
                        }
                    }
                    foreach (var playerScore in scoreCounter)
                    {
                        Console.WriteLine($"{playerScore.Key}: {playerScore.Value}");
                    }
                    return;
                }
                input.RemoveAt(0);
                var result = new List<string> (input[0].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries));

                if (!cards.ContainsKey(Name))
                {
                    cards[Name] = new List<string>();
                }

                foreach (var entry in result)
                {
                    cards[Name].Add(entry);
                }
            }
        }
    }
}