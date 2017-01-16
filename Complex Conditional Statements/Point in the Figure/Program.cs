using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            string result = "";

            if (x <= h * 3 && x >= 0 && y <= h && y >= 0)
            {
                if ((((((x >= 0 && x <= h) || (x >= h * 2 && x <= h * 3)) && y == h) || (((x >= 0 && x <= h * 3)) && y == 0))) || ((x == 0 || x == h * 3) && (y >= 0 || y <= h)))
                {
                    result = "border";
                }
                else
                {
                    result = "inside";
                }
            }
            else if (x >= h && x <= h * 2 && y >= 0 && y <= h * 4)
            {
                if ((x >= h && x <= h * 2 && y == h * 4) || ((x == h || x == h * 2) && (y >= h || y <= h * 4)))
                {
                    result = "border";
                }
                else
                {
                    result = "inside";
                }
            }
            else
            {
                result = "outside";
            }

            Console.WriteLine(result);
        }
    }
}