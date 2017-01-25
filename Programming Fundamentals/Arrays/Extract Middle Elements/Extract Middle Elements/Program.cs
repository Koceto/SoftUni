using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_Elements
{
    public class PrintMiddle
    {
        public static void Main()
        {
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (number.Length == 1)
            {
                Console.WriteLine($"{{ {number[0]} }}");
            }
            else if (number.Length % 2 == 0)
            {
                PrintMiddleIfEven(number);
            }
            else
            {
                PrintMiddleIfOdd(number);
            }

        }

        private static void PrintMiddleIfEven(int[] number)
        {
            int firstChar = (number.Length / 2) - 1;
            int secondChar = number.Length / 2;
            Console.WriteLine($"{{ {number[firstChar]}, {number[secondChar]} }}");
        }

        public static void PrintMiddleIfOdd(int[] number)
        {
            int firstChar = (number.Length / 2) - 1;
            int secondChar = number.Length / 2;
            int thirdChar = (number.Length / 2) + 1;
            Console.WriteLine($"{{ {number[firstChar]}, {number[secondChar]}, {number[thirdChar]} }}");
        }
    }
}
