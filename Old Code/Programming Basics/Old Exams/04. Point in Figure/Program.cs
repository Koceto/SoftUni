using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Point_in_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1Cube1 = 4;
            int x2Cube1 = 10;
            int y1Cube1 = -5;
            int y2Cube1 = 3;


            int x1Cube2 = 2;
            int x2Cube2 = 12;
            int y1Cube2 = -3;
            int y2Cube2 = 1;

            bool point = true;

            if (x >= x1Cube1 && x <= x2Cube1 && y >= y1Cube1 && y <= y2Cube1)
            {
                point = true;
            }
            else if (x >= x1Cube2 && x <= x2Cube2 && y >= y1Cube2 && y <= y2Cube2)
            {
                point = true;
            }
            else
            {
                point = false;
            }

            Console.WriteLine("{0}", point ? "in" : "out");
        }
    }
}
