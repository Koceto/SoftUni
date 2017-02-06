using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double rectangleWidth = double.Parse(Console.ReadLine());
            double rectangleHeight = double.Parse(Console.ReadLine());

            double rectanglePerimeter = 2 * (rectangleWidth + rectangleHeight);
            double rectangleArea = rectangleWidth * rectangleHeight;
            double rectangleDiagonal = Math.Sqrt(Math.Pow(rectangleHeight, 2) + Math.Pow(rectangleWidth, 2));

            Console.WriteLine(rectanglePerimeter);
            Console.WriteLine(rectangleArea);
            Console.WriteLine(rectangleDiagonal);
        }
    }
}
