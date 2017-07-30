using System;
using System.Linq;

namespace Target_Practice
{
    public static class StartUp
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var snake = Console.ReadLine().Trim();
            var shot = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new char[dimentions.First()][];
            var evenLines = 0;

            for (int rowIndex = matrix.Length - 1, fillCounter = 0; rowIndex >= 0; rowIndex--)
            {
                matrix[rowIndex] = new char[dimentions.Last()];

                if (evenLines % 2 == 0)
                {
                    for (int colIndex = matrix[rowIndex].Length - 1; colIndex >= 0; colIndex--, fillCounter++)
                    {
                        matrix[rowIndex][colIndex] = snake[fillCounter % snake.Length];
                    }
                }
                else if (evenLines % 2 != 0)
                {
                    for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++, fillCounter++)
                    {
                        matrix[rowIndex][colIndex] = snake[fillCounter % snake.Length];
                    }
                }
                evenLines++;
            }

            CalculateBlastArea(matrix, shot[0], shot[1], shot[2]);
            BlastAreaDemage(matrix);

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        public static void BlastAreaDemage(char[][] matrix)
        {
            for (int rowIndex = matrix.Length - 1; rowIndex > 0; rowIndex--)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    if (matrix[rowIndex][colIndex] == ' ')
                    {
                        var count = 0;

                        while (rowIndex - count >= 0)
                        {
                            if (matrix[rowIndex - count][colIndex] != ' ')
                            {
                                matrix[rowIndex][colIndex] = matrix[rowIndex - count][colIndex];
                                matrix[rowIndex - count][colIndex] = ' ';
                                break;
                            }
                            count++;
                        }
                    }
                }
            }
        }

        public static void CalculateBlastArea(char[][] matrix, int shotRow, int shotCol, int shotStrenght)
        {
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    if (Math.Pow(rowIndex - shotRow, 2) + Math.Pow(colIndex - shotCol, 2) <= Math.Pow(shotStrenght, 2))
                    {
                        matrix[rowIndex][colIndex] = ' ';
                    }
                }
            }
        }
    }
}