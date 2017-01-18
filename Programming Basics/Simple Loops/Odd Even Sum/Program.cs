using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesToWrite = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;

            for (int write = 0; write < timesToWrite; write++)
            {
                int num = int.Parse(Console.ReadLine());

                if (write % 2 == 0)
                {
                    even += num;
                }
                else
                {
                    odd += num;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("yes sum " + even);
            }
            else
            {
                Console.WriteLine("no diff " + Math.Abs(even - odd));
            }
        }
    }
}
