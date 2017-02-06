using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Floating_Point_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dataDouble = decimal.Parse(Console.ReadLine());
            decimal dataFloat = decimal.Parse(Console.ReadLine());
            decimal dataDecimal = decimal.Parse(Console.ReadLine());

            Console.WriteLine(dataDouble);
            Console.WriteLine(dataFloat);
            Console.WriteLine(dataDecimal);
        }
    }
}
