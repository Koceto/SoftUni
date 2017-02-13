using System;
using System.Linq;

namespace Circles_Intersection
{
    public class CirclesIntersection
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var firstCircle = new Circle
            {
                X = firstInput[0],
                Y = firstInput[1],
                Radius = firstInput[2]
            };

            var secondInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var secondCircle = new Circle
            {
                X = secondInput[0],
                Y = secondInput[1],
                Radius = secondInput[2]
            };

            if (Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            var distance = Math.Abs((firstCircle.X + firstCircle.Y) - (secondCircle.X + secondCircle.Y)) / 2;

            if (distance <= firstCircle.Radius + secondCircle.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
