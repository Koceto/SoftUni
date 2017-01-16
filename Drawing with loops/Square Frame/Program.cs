using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dash = new string('-', 1) + new string(' ', 1);

            Console.WriteLine("+ {0}+", string.Concat(Enumerable.Repeat(dash, n - 2)));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("| {0}|", string.Concat(Enumerable.Repeat(dash, n - 2)));
            }

            Console.WriteLine("+ {0}+", string.Concat(Enumerable.Repeat(dash, n - 2)));
        }
    }
}
