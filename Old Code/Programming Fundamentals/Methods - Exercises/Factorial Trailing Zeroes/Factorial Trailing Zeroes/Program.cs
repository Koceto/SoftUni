using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger result = Factorial(number);
            int numberOfZeroes = TrailingZeroes(result);

            Console.WriteLine(numberOfZeroes);
        }

        private static int TrailingZeroes(BigInteger result)
        {
            int numberOfZeroes = 0;
            while (true)
            {
                if (result % 10 == 0)
                {
                    numberOfZeroes++;
                    result /= 10;
                }
                else
                {
                    return numberOfZeroes;
                }
            }
        }

        private static BigInteger Factorial(int number)
        {
            BigInteger result = 1;

            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
