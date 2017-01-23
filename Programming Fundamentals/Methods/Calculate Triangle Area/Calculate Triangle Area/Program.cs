using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    public class Program
    {
        public static void Main()
        {
            double triangleBase = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());

            Console.WriteLine(TriangleArea(triangleBase, triangleHeight));
        }

        private static double TriangleArea(double triangleBase, double triangleHeight)
        {
            return (triangleBase * triangleHeight) / 2;
        }
    }
}
