using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars_EXPLAINED
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            var row = new string('*', n);

            Console.WriteLine(row);

            for (int i = 0; i < n - 2; i++)
            {
                var line = new string(' ', n - 2);
                Console.WriteLine("*" + line + "*");
            }


            Console.WriteLine(row);
        }
    }
}
