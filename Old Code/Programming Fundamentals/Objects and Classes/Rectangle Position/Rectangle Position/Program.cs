using System;
using System.Linq;

namespace Rectangle_Position
{
    public class RectanglePosition
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var secondInput = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Rectangle firstRectangle = new Rectangle
            {
                Left = firstInput[0],
                Top = firstInput[1],
                Width = firstInput[2],
                Height = firstInput[3]
            };

            Rectangle secondRectangle = new Rectangle
            {
                Left = secondInput[0],
                Top = secondInput[1],
                Width = secondInput[2],
                Height = secondInput[3]
            };

            if (firstRectangle.Left >= secondRectangle.Left
                && firstRectangle.Right <= secondRectangle.Right
                && firstRectangle.Top >= secondRectangle.Top
                && firstRectangle.Bottom <= secondRectangle.Bottom)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
}
