using System;
using System.Collections.Generic;

namespace Sum_big_numbers
{
    public class Program
    {
        public static void Main()
        {
            var firstNumber = Console.ReadLine().TrimStart('0');
            var multiplyer = int.Parse(Console.ReadLine());
            var result = new Stack<int>();
            var remainder = 0;

            if (multiplyer == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                var currFirst = int.Parse(firstNumber[i].ToString());
                var currResult = currFirst * multiplyer + remainder;

                if (currResult > 9)
                {
                    result.Push(currResult % 10);
                    remainder = currResult / 10;
                }
                else
                {
                    result.Push(currResult);
                    remainder = 0;
                }
            }

            if (remainder != 0)
            {
                result.Push(remainder);
            }

            foreach (var number in result)
            {
                Console.Write(number);
            }
        }
    }
}