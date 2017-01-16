using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int square = int.Parse(Console.ReadLine());
            string star = new string('*', 1) + new string(' ', 1);

            for (int rows = 0; rows < square; rows++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat(star, square)));
            }
        }
    }
}
