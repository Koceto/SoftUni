using System;
using System.Collections.Generic;
using System.Linq;

namespace Closest_Two_Points
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var pointsList = new List<Points>();
            double minDistance = double.MaxValue;
            
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                pointsList.Add(new Points
                {
                    x = input[0],
                    y = input[1]
                });
            }

            Points firstMax = null;
            Points secondMax = null;

            for (int i = 0; i < pointsList.Count - 1; i++)
            {
                for (int j = i + 1; j < pointsList.Count; j++)
                {
                    var firstPoint = pointsList[i];
                    var secondPoint = pointsList[j];

                    var currentDiff = CalcPointDiff(firstPoint, secondPoint);

                    if (currentDiff < minDistance)
                    {
                        minDistance = currentDiff;
                        firstMax = firstPoint;
                        secondMax = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({firstMax.x}, {firstMax.y})");
            Console.WriteLine($"({secondMax.x}, {secondMax.y})");
        }

        private static double CalcPointDiff(Points firstPoint, Points secondPoint)
        {
            var diffX = firstPoint.x - secondPoint.x;
            var diffY = firstPoint.y - secondPoint.y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }
    }
}
