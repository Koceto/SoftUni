using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    public class Program
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstPoint = Math.Abs(x1) + Math.Abs(y1);
            double secondPoint = Math.Abs(x2) + Math.Abs(y2);
            double thirdPoint = Math.Abs(x3) + Math.Abs(y3);
            double fourthPoint = Math.Abs(x4) + Math.Abs(y4);

            double firstLine = firstPoint + secondPoint;
            double secondLine = thirdPoint + fourthPoint;

            if (firstLine >= secondLine)
            {
                CloserPoint(x1, y1, x2, y2);
            }
            else
            {
                CloserPoint(x3, y3, x4, y4);
            }
        }

        public static void CloserPoint(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Abs(x1) + Math.Abs(y1);
            double secondPoint = Math.Abs(x2) + Math.Abs(y2);

            if (firstPoint <= secondPoint)
            {
                Console.Write($"({x1}, {y1})");
                Console.Write($"({x2}, {y2})");
            }
            else
            {
                Console.Write($"({x2}, {y2})");
                Console.Write($"({x1}, {y1})");
            }
        }
    }
}
