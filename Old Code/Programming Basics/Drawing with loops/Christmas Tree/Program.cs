using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} | {0}", new string(' ', n));

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1} | {1}",
                    new string(' ', n - i),
                    new string('*', i));
            }
        }
    }
}
