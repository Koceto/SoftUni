using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    public class Program
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            string operation = (Console.ReadLine()).ToLower();

            switch (operation)
            {
                case "face":
                    CubeFaceDiagonals(width);
                    break;
                case "space":
                    CubeSpaceDiagonals(width);
                    break;
                case "volume":
                    CubeVolume(width);
                    break;
                default:
                    CubeArea(width);
                    break;
            }
        }

        private static void CubeArea(double width)
        {
            double area = width * width;
            double totalArea = 6 * area;
            Console.WriteLine($"{totalArea:f2}");
        }

        private static void CubeVolume(double width)
        {
            double volume = width * width * width;
            Console.WriteLine($"{volume:f2}");
        }

        private static void CubeSpaceDiagonals(double width)
        {
            double space = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(width, 2) + Math.Pow(width, 2));
            Console.WriteLine($"{space:f2}");
        }

        private static void CubeFaceDiagonals(double width)
        {
            double face = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(width, 2));
            Console.WriteLine($"{face:f2}");
        }
    }
}
