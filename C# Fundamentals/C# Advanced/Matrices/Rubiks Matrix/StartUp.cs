using System;
using System.Linq;

namespace Rubiks_Matrix
{
    public static class StartUp
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var n = int.Parse(Console.ReadLine());
            var matrix = new int[dimentions.First()][];
            var fillCounter = 1;

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex] = new int[dimentions.Last()];

                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    matrix[rowIndex][colIndex] = fillCounter;
                    fillCounter++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var direction = input[1].ToLower();
                var moves = int.Parse(input.Last());
                var index = int.Parse(input.First());

                if (direction == "left") // Move Rows
                {
                    for (int timesIndex = 0; timesIndex < moves % matrix[index].Length; timesIndex++)
                    {
                        var first = matrix[index][0];

                        for (int colIndex = 0; colIndex < matrix[index].Length - 1; colIndex++)
                        {
                            matrix[index][colIndex] = matrix[index][colIndex + 1];
                        }

                        matrix[index][matrix[index].Length - 1] = first;
                    }
                }
                else if (direction == "right") // Move Rows
                {
                    for (int timesIndex = moves % matrix[index].Length; timesIndex > 0; timesIndex--)
                    {
                        var last = matrix[index][matrix[index].Length - 1];

                        for (int colIndex = matrix[index].Length - 1; colIndex > 0; colIndex--)
                        {
                            matrix[index][colIndex] = matrix[index][colIndex - 1];
                        }

                        matrix[index][0] = last;
                    }
                }
                else if (direction == "down") // Move Cols
                {
                    for (int timesIndex = moves % matrix.Length; timesIndex > 0; timesIndex--)
                    {
                        var last = matrix[matrix.Length - 1][index];

                        for (int rowIndex = matrix.Length - 1; rowIndex > 0; rowIndex--)
                        {
                            matrix[rowIndex][index] = matrix[rowIndex - 1][index];
                        }

                        matrix[0][index] = last;
                    }
                }
                else if (direction == "up") // Move Cols
                {
                    for (int timesIndex = 0; timesIndex < moves % matrix.Length; timesIndex++)
                    {
                        var first = matrix[0][index];

                        for (int colIndex = 0; colIndex < matrix.Length - 1; colIndex++)
                        {
                            matrix[colIndex][index] = matrix[colIndex + 1][index];
                        }

                        matrix[matrix[index].Length - 1][index] = first;
                    }
                }
            }

            var searchCounter = 1;
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    if (matrix[rowIndex][colIndex] == searchCounter)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        Console.WriteLine($"Swap ({rowIndex}, {colIndex}) with ({FindIndex(matrix, searchCounter, rowIndex, colIndex)})");
                    }

                    searchCounter++;
                }
            }
        }

        private static string FindIndex(int[][] matrix, int searchCounter, int firstNumberRow, int firstNumberCol)
        {
            var position = "0, 0";
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    if (matrix[rowIndex][colIndex] == searchCounter)
                    {
                        position = $"{rowIndex}, {colIndex}";
                        var temp = matrix[firstNumberRow][firstNumberCol];
                        matrix[firstNumberRow][firstNumberCol] = matrix[rowIndex][colIndex];
                        matrix[rowIndex][colIndex] = temp;
                    }
                }
            }
            return position;
        }
    }
}