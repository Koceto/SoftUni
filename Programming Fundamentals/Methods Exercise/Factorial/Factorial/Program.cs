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
            
            Console.WriteLine(Factorial(number));
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
