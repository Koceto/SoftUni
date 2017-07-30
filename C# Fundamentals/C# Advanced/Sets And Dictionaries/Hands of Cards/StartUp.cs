using System;
using System.Collections.Generic;
using System.Linq;

namespace Hands_of_Cards
{
    public static class StartUp
    {
        public static void Main()
        {
            var players = new HashSet<Player>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.ToLower() == "joker")
                {
                    break;
                }

                var playerName = input
                    .Split(':')
                    .First();
                var playerCards = input
                    .Split(':')
                    .Last()
                    .Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (players.Any(p => p.Name == playerName))
                {
                    foreach (var card in playerCards)
                    {
                        players.First(p => p.Name == playerName).Cards.Add(card);
                    }
                }
                else
                {
                    players.Add(new Player()
                    {
                        Name = playerName,
                        Cards = new HashSet<string>(playerCards)
                    });
                }
            }

            foreach (var player in players)
            {
                Console.Write($"{player.Name}: ");

                var score = CalculateScore(player.Cards);

                Console.Write($"{score} {Environment.NewLine}");
            }
        }

        private static int CalculateScore(HashSet<string> cards)
        {
            int power = 0;

            foreach (var card in cards)
            {
                var cardPower = string.Join("", card.ToCharArray().Reverse().Skip(1).Reverse());
                var cardType = string.Join("", card.ToCharArray().Reverse().Take(1));

                switch (cardType)
                {
                    case "S":
                        power += CardPower(cardPower) * 4;
                        break;

                    case "H":
                        power += CardPower(cardPower) * 3;
                        break;

                    case "D":
                        power += CardPower(cardPower) * 2;
                        break;

                    default:
                        power += CardPower(cardPower);
                        break;
                }
            }

            return power;
        }

        private static int CardPower(string power)
        {
            switch (power)
            {
                case "J":
                    return 11;

                case "Q":
                    return 12;

                case "K":
                    return 13;

                case "A":
                    return 14;

                default:
                    return int.Parse(power);
            }
        }
    }
}