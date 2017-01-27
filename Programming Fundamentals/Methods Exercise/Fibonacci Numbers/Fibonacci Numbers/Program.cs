using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(FibNumber(int.Parse(Console.ReadLine())));
        }

        public static int FibNumber(int number)
        {
            int result = 0;
            int secondNumber = 1;

            for (int i = 0; i <= number; i++)
            {
                int firstNumber = result;
                result = secondNumber + firstNumber;
                secondNumber = firstNumber;

                if (i == number)
                {
                    return result;
                }
            }
            return ' ';
        }
    }
}
