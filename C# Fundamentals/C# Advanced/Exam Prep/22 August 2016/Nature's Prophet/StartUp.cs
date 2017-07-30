using System;
using System.Collections.Generic;
using System.Linq;

namespace Nature_s_Prophet
{
    public static class StartUp
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[][] garden = new int[dimensions[0]][];
            Stack<Index> indexStack = new Stack<Index>();

            for (int i = 0; i < dimensions[0]; i++)
            {
                garden[i] = new int[dimensions[1]];
            }

            string input;

            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] plantingIndex = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                indexStack.Push(new Index()
                {
                    Row = plantingIndex[0],
                    Col = plantingIndex[1]
                });
            }

            while (indexStack.Count > 0)
            {
                for (int rowIndex = 0; rowIndex < garden.Length; rowIndex++)
                {
                    garden[rowIndex][indexStack.Peek().Col] += 1;
                }

                for (int colIndex = 0; colIndex < garden[0].Length; colIndex++)
                {
                    if (indexStack.Peek().Col != colIndex)
                    {
                        garden[indexStack.Peek().Row][colIndex] += 1;
                    }
                }

                indexStack.Pop();
            }

            Printgarden(garden);
        }

        private static void Printgarden(int[][] garden)
        {
            foreach (var row in garden)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}