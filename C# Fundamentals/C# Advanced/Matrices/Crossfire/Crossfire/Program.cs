using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossfire
{
    public class Program
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new List<List<int>>();
            var fillCounter = 1;

            for (int row = 0; row < dimentions[0]; row++)
            {
                matrix.Add(new List<int>());

                for (int col = 0; col < dimentions[1]; col++)
                {
                    matrix[row].Add(fillCounter);
                    fillCounter++;
                }
            }


            var input = Console.ReadLine();

            while (input.ToLower() != "nuke it from orbit")
            {

                var command = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                DestroyCells(matrix, command);

                input = Console.ReadLine();
            }

            PrintResults(matrix);
        }

        private static void PrintResults(List<List<int>> matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static void DestroyCells(List<List<int>> matrix, int[] command)
        {
            var shotRow = command[0];
            var shotCol = command[1];
            var shotStrenght = command[2];

            for (int rowIndex = shotRow - shotStrenght; rowIndex <= shotRow + shotStrenght; rowIndex++)
            {
                if (IsInMatrix(matrix, rowIndex, shotCol))
                {
                    matrix[rowIndex][shotCol] = -1;
                }
            }

            for (int colIndex = shotCol - shotStrenght; colIndex <= shotCol + shotStrenght; colIndex++)
            {
                if (IsInMatrix(matrix, shotRow, colIndex))
                {
                    matrix[shotRow][colIndex] = -1;
                }
            }
            RearangeCells(matrix);
        }

        private static bool IsInMatrix(List<List<int>> matrix, int rowIndex, int colIndex)
        {
            if (rowIndex >= 0 && rowIndex < matrix.Count &&
                colIndex >= 0 && colIndex < matrix[rowIndex].Count)
            {
                return true;
            }
            return false;
        }

        private static void RearangeCells(List<List<int>> matrix)
        {
            for (int row = matrix.Count - 1; row >= 0; row--)
            {
                for (int col = matrix[row].Count - 1; col >= 0; col--)
                {
                    if (matrix[row][col] == -1)
                    {
                        matrix[row].RemoveAt(col);
                    }
                }

                if (matrix[row].Count == 0)
                {
                    matrix.RemoveAt(row);
                }
            }
        }
    }
}