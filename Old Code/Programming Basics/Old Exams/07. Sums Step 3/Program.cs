using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sums_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 1;
            int sum2 = 2;
            int sum3 = 3;
            int result1 = 0;
            int result2 = 0;
            int result3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i == sum1)
                {
                    result1 += num;
                    sum1 += 3;
                }
                else if (i == sum2)
                {
                    result2 += num;
                    sum2 += 3;
                }
                else if (i == sum3)
                {
                    result3 += num;
                    sum3 += 3;
                }
            }
            Console.WriteLine("sum1 = {0}", result1);
            Console.WriteLine("sum2 = {0}", result2);
            Console.WriteLine("sum3 = {0}", result3);
        }
    }
}
