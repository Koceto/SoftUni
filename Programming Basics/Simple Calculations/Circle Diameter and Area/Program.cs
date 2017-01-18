using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleDiameterandArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var pi = Math.PI;
            var area = pi * r * r;
            var perimeter = 2 * pi * r;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
