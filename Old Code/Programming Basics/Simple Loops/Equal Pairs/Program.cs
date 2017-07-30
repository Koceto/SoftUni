using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeToRepeat = int.Parse(Console.ReadLine());
            int num1 = new int();
            int num2 = new int();
            int maxDiff = new int();
            int pair = new int();

            for (int repeat = 1; repeat <= timeToRepeat; repeat++)
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                int pair2 = num1 + num2;

                if (repeat == 1)
                {
                    pair = pair2;
                    maxDiff = 0;
                }
                if (Math.Abs(pair - pair2) != maxDiff)
                {
                    maxDiff = Math.Abs(pair - pair2);
                    pair = pair2;
                }
            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value = " + pair);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + maxDiff);
            }

        }
    }
}
