using System;
using System.Collections.Generic;

namespace Sum_big_numbers
{
    public class Program
    {
        public static void Main()
        {
            var firstNumber = Console.ReadLine().TrimStart('0');
            var secondNumber = Console.ReadLine().TrimStart('0');
            var result = new Stack<int>();
            var remainder = 0;
            var longest = Math.Max(firstNumber.Length, secondNumber.Length);

            firstNumber = firstNumber.PadLeft(longest, '0');
            secondNumber = secondNumber.PadLeft(longest, '0');

            for (int i = longest - 1; i >= 0; i--)
            {
                var currFirst = int.Parse(firstNumber[i].ToString());
                var currSecond = int.Parse(secondNumber[i].ToString());
                var currResult = currFirst + currSecond + remainder;

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