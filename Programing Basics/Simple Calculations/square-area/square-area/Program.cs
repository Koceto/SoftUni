using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var side = double.Parse(Console.ReadLine());
            var square = side * side;
            Console.WriteLine("Square = {0}", square);
        }
    }
}
