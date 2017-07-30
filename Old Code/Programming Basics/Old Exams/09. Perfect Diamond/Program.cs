using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int diamondWidth = n * 2 - 1;

            for (int topRows = 1; topRows <= n * 2 - 1; topRows++)
            {
                int diamondCount = topRows <= n ?
                    (topRows * 2 - 2) / 2 :
                    n * 2 - topRows - 1;
                string diamondPattern =
                    new string('*', 1) +
                    new string('-', 1);

                Console.WriteLine("{1}{0}*",
                    string.Concat(Enumerable.Repeat(diamondPattern, diamondCount)),
                    new string(' ',
                    topRows <= n ?
                    n - topRows :
                    topRows - n));
            }
        }
    }
}
