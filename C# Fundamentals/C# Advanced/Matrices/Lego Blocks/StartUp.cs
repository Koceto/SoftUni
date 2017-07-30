using System;
using System.Linq;

namespace Lego_Blocks
{
    public static class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var firstMatrix = new int[n][];
            var secondMatrix = new int[n][];
            var totalMatrixWidth = 0;
            var totalCells = 0;

            for (int i = 0; i < n; i++)
            {
                var firstInput = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                firstMatrix[i] = new int[firstInput.Length];
                firstMatrix[i] = firstInput;
                totalCells += firstInput.Length;
            }

            for (int i = 0; i < n; i++)
            {
                var secondInput = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                secondMatrix[i] = new int[secondInput.Length];
                secondMatrix[i] = secondInput;
                totalCells += secondInput.Length;
            }

            totalMatrixWidth = firstMatrix[0].Length + secondMatrix[0].Length;

            var totalMatrix = new int[n][];

            for (int rowsIndex = 0; rowsIndex < n; rowsIndex++)
            {
                if (totalMatrixWidth != firstMatrix[rowsIndex].Length + secondMatrix[rowsIndex].Length)
                {
                    Console.WriteLine($"The total number of cells is: {totalCells}");
                    return;
                }
                else
                {
                    totalMatrix[rowsIndex] = new int[totalMatrixWidth];

                    for (int col = 0, secondCol = 0; col < totalMatrixWidth; col++)
                    {
                        if (firstMatrix[rowsIndex].Length > col)
                        {
                            totalMatrix[rowsIndex][col] = firstMatrix[rowsIndex][col];
                        }
                        else
                        {
                            totalMatrix[rowsIndex][col] = secondMatrix[rowsIndex][secondMatrix[rowsIndex].Length - 1 - secondCol];
                            secondCol++;
                        }
                    }
                }
            }

            foreach (var row in totalMatrix)
            {
                Console.WriteLine($"[{string.Join(", ", row)}]");
            }
        }
    }
}