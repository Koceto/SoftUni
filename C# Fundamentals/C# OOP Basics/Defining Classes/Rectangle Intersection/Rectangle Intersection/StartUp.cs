using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectangle_Intersection
{
    public class StartUp
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int numberOfRectangles = input[0];
            int numberofIntersectionChecks = input[1];
            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < numberOfRectangles; i++)
            {
                string[] data = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] rectangleInfo = data.Skip(1).Select(int.Parse).ToArray();
                rectangles.Add(new Rectangle(data[0], rectangleInfo[0], rectangleInfo[1], rectangleInfo[2], rectangleInfo[3]));
            }

            for (int i = 0; i < numberofIntersectionChecks; i++)
            {
                string[] rectanglesToCheck = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Rectangle first = rectangles.First(r => r.ID == rectanglesToCheck[0]);
                Rectangle second = rectangles.First(r => r.ID == rectanglesToCheck[1]);

                if (first.Intersects(second))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}