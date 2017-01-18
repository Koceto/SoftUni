using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dollar = new string('$', 1) + new string(' ', 1);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat(dollar, i)));
            }
        }
    }
}
