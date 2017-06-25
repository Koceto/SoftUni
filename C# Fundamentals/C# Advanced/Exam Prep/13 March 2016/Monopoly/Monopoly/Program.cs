using System;
using System.Linq;

namespace Monopoly
{
    internal class Program
    {
        private static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[][] matrix = new char[dimensions[0]][];
            int turns = 0;
            int money = 50;
            int hotelsOwned = 0;

            for (int i = 0; i < dimensions[0]; i++)
            {
                matrix[i] = new char[dimensions[1]];

                matrix[i] = Console.ReadLine().ToLower().ToCharArray();
            }

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                int colIndex = 0;
                bool condition = colIndex < matrix[rowIndex].Length;

                if (rowIndex % 2 != 0)
                {
                    colIndex = matrix[rowIndex].Length - 1;
                    condition = colIndex >= 0;
                }

                while (condition)
                {
                    char landMark = matrix[rowIndex][colIndex];

                    if (landMark == 'h')
                    {
                        hotelsOwned++;

                        Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotelsOwned}.");

                        money = 0;
                    }
                    else if (landMark == 'j')
                    {
                        Console.WriteLine($"Gone to jail at turn {turns}.");

                        turns += 2;
                        money += hotelsOwned * 10 * 2;
                    }
                    else if (landMark == 's')
                    {
                        int row = rowIndex + 1;
                        int col = colIndex + 1;

                        int moneySpent = row * col;

                        if (money - row * col < 0)
                        {
                            moneySpent = money;
                        }

                        money = Math.Max(0, money - row * col);

                        Console.WriteLine($"Spent {moneySpent} money at the shop.");
                    }

                    money += hotelsOwned * 10;
                    turns++;

                    if (rowIndex % 2 == 0)
                    {
                        colIndex++;
                        condition = colIndex < matrix[rowIndex].Length;
                    }
                    else
                    {
                        colIndex--;
                        condition = colIndex >= 0;
                    }
                }
            }

            Console.WriteLine($"Turns {turns}");
            Console.WriteLine($"Money {money}");
        }
    }
}