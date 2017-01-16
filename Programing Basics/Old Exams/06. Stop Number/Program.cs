using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            for (; n <= m; m--)
            {
                if (m % 2 == 0 && m % 3 == 0)
                {
                    if (m != stop)
                        Console.Write(m + " ");
                    else
                        return;
                }
            }
        }
    }
}
