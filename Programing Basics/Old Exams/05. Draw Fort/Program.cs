using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(@"/{0}\{1}/{0}\",
                new string('^', n / 2),
                new string('_', n * 2 - 4 - ((n / 2) * 2)));

            for (int rows = 0; rows < n - 3; rows++)
            {
                Console.WriteLine("|{0}|", new string(' ', n * 2 - 2));
            }

            Console.WriteLine("|{0}{1}{0}|",
                new string(' ', n / 2 + 1),
                new string('_', (n * 2 - 4 - n / 2 * 2)));
            Console.WriteLine(@"\{0}/{1}\{0}/",
                new string('_', n / 2),
                new string(' ', (n * 2 - 4 - n / 2 * 2)));

        }
    }
}
