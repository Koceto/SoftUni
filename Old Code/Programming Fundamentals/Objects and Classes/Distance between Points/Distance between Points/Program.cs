using System;
using System.Linq;

namespace Distance_between_Points
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPointParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var secondPointParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int y = firstPointParts[0] - secondPointParts[0];
            int x = firstPointParts[1] - secondPointParts[1];
            var result = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(x, 2));

            Console.WriteLine($"{result:f3}");
        }
    }
}
