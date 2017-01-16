using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeToRepeat = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int result = new int();

            for (int repeat = 0; repeat < timeToRepeat; repeat++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >= maxNum)
                {
                    maxNum = num;
                }

                result += num;
            }
            if ((result - maxNum) == maxNum)
            {
                Console.WriteLine("yes sum " + (result - maxNum));
            }
            else
            {
                Console.WriteLine("no diff " + Math.Abs(result - maxNum * 2));
            }
        }
    }
}
