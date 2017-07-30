using System;
using System.Globalization;

namespace The_Heigan_Dance
{
    public static class StartUp
    {
        public const int RoomWidth = 15;
        public const int PlagueDamage = 3500;
        public const int EruptionDamage = 6000;
        public const int PlayerStartHealth = 18500;
        public const int HeiganStarthealth = 3000000;

        public static void Main()
        {
            double playerDamage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double heiganHealth = HeiganStarthealth;
            var playerHealth = PlayerStartHealth;
            var playerPos = new[] { RoomWidth / 2, RoomWidth / 2 };
            var isPlayerInfected = false;
            var isPlayerDead = false;
            var isHeiganDead = false;
            var playerDeathCause = string.Empty;

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(' ');
                var spell = input[0];
                var row = int.Parse(input[1]);
                var col = int.Parse(input[2]);

                heiganHealth -= playerDamage;
                isHeiganDead = heiganHealth <= 0;

                if (isPlayerInfected)
                {
                    playerHealth -= PlagueDamage;
                    isPlayerDead = playerHealth <= 0;
                    isPlayerInfected = false;
                }

                if (!isPlayerDead && !isHeiganDead && !CanPlayerEvade(row, col, playerPos))
                {
                    switch (spell.ToLower())
                    {
                        case "cloud":
                            playerHealth -= PlagueDamage;
                            isPlayerDead = playerHealth <= 0;
                            playerDeathCause = "Plague Cloud";
                            isPlayerInfected = true;
                            break;

                        case "eruption":
                            playerHealth -= EruptionDamage;
                            isPlayerDead = playerHealth <= 0;
                            playerDeathCause = "Eruption";
                            break;
                    }
                }

                if (isHeiganDead || isPlayerDead)
                {
                    PrintResults(heiganHealth, playerHealth, playerDeathCause, playerPos);
                    break;
                }
            }
        }

        private static void PrintResults(double heiganHealth, int playerHealth, string playerDeathCause, int[] playerPos)
        {
            Console.WriteLine("Heigan: {0}",
                heiganHealth <= 0 ? "Defeated!" : $"{heiganHealth:f2}");
            Console.WriteLine("Player: {0}",
                playerHealth <= 0 ? $"Killed by {playerDeathCause}" : $"{playerHealth}");
            Console.WriteLine($"Final position: {playerPos[0]}, {playerPos[1]}");
        }

        private static bool CanPlayerEvade(int row, int col, int[] playerPos)
        {
            var evadeDamage = false;

            if (IsInDamageArea(playerPos[0], row) &&
                IsInDamageArea(playerPos[1], col))
            {
                if (playerPos[0] - 1 >= 0 && !IsInDamageArea(playerPos[0] - 1, row)) // player Tries to go UP
                {
                    playerPos[0]--;
                    evadeDamage = true;
                }
                else if (playerPos[1] + 1 < RoomWidth && !IsInDamageArea(playerPos[1] + 1, col)) // player Tries to go RIGHT
                {
                    playerPos[1]++;
                    evadeDamage = true;
                }
                else if (playerPos[0] + 1 < RoomWidth && !IsInDamageArea(playerPos[0] + 1, row)) // player Tries to go DOWN
                {
                    playerPos[0]++;
                    evadeDamage = true;
                }
                else if (playerPos[1] - 1 >= 0 && !IsInDamageArea(playerPos[1] - 1, col)) // player Tries to go LEFT
                {
                    playerPos[1]--;
                    evadeDamage = true;
                }
            }
            else
            {
                evadeDamage = true;
            }

            return evadeDamage;
        }

        private static bool IsInDamageArea(int playerPos, int length)
        {
            return Math.Abs(playerPos - length) < 2;
        }
    }
}