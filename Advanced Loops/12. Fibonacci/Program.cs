using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f1 = 1;
            int f2 = 1;
            int num = 0;

            for (int i = 1; i < n; i++)
            {
                num = f1 + f2;
                f1 = f2;
                f2 = num;
            }
            Console.WriteLine(f2);
        }
    }
}
