using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
            for (int rows = 1; rows <= n - 2; rows++)
            {
                if (n % 2 != 0)
                {
                    if (rows == n / 2)
                    {
                        //bridge
                        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', (n * 2) - 2), new string('|', n));
                    }
                    else
                    {
                        // no bridge
                        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', (n * 2) - 2), new string(' ', n));
                    }
                }
                else
                {

                    if (rows == (n / 2) - 1)
                    {
                        //bridge
                        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', (n * 2) - 2), new string('|', n));
                    }
                    else
                    {
                        // no bridge
                        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', (n * 2) - 2), new string(' ', n));
                    }
                }
            }
            Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
        }
    }
}
