using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_System
{
    public class Program
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Trim()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var matrix = new int[dimentions[0]][];
            var input = string.Empty;

            while ((input = Console.ReadLine().Trim()) != "stop")
            {
                var coords = input.Split(' ').Select(int.Parse).ToArray();
                var entryRow = coords[0];
                var parkingSpaceRow = coords[1];
                var parkingSpaceCol = coords[2];

                if (matrix[parkingSpaceRow] == null)
                {
                    matrix[parkingSpaceRow] = new int[dimentions[1]];
                }

                if (matrix[parkingSpaceRow][parkingSpaceCol] == 0) // Parking Space is Free
                {
                    matrix[parkingSpaceRow][parkingSpaceCol] = 1;
                    Console.WriteLine(Math.Abs(entryRow - parkingSpaceRow) + parkingSpaceCol + 1); //Initial move to enter the parking = 1
                }
                else
                {
                    var newParkingSpaceCol = FindAlternativeParkingSpace(matrix, parkingSpaceRow, parkingSpaceCol);

                    if (newParkingSpaceCol == -1)
                    {
                        Console.WriteLine($"Row {parkingSpaceRow} full");
                        continue;
                    }

                    matrix[parkingSpaceRow][newParkingSpaceCol] = 1;
                    Console.WriteLine(Math.Abs(entryRow - parkingSpaceRow) + newParkingSpaceCol + 1); //Initial move to enter the parking = 1
                }
            }
        }

        private static int FindAlternativeParkingSpace(int[][] matrix, int parkingSpaceRow, int parkingSpaceCol)
        {
            var freeSpaceDistance = int.MaxValue;
            var newParkingSpaceCol = -1;

            for (int i = 1; i < matrix[parkingSpaceRow].Length; i++)
            {
                if (matrix[parkingSpaceRow][i] == 0)
                {
                    var distanceFromOriginalPosition = Math.Abs(parkingSpaceCol - i);

                    if (distanceFromOriginalPosition < freeSpaceDistance)
                    {
                        freeSpaceDistance = distanceFromOriginalPosition;
                        newParkingSpaceCol = i;
                    }
                }
            }

            return newParkingSpaceCol;
        }
    }
}