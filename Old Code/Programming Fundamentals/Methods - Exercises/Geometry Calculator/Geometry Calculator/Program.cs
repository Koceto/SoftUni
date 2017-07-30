using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    public class Program
    {
        public static void Main()
        {
            string typeOfFigure = (Console.ReadLine()).ToLower();

            switch (typeOfFigure)
            {
                case "triangle":
                    TriangleArea();
                    break;
                case "square":
                    SquareArea();
                    break;
                case "rectangle":
                    RectangleArea();
                    break;
                case "circle":
                    CircleArea();
                    break;
            }
        }

        private static void CircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"{area:f2}");
        }

        private static void RectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine($"{area:f2}");
        }

        private static void SquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine($"{area:f2}");
        }

        private static void TriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = (side * height) / 2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
