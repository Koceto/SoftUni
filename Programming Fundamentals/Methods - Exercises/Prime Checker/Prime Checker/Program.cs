using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(IsPrime(long.Parse(Console.ReadLine())));
        }

        public static bool IsPrime(long number)
        {
            bool prime = true;

            if (number == 0 || number == 1 || number == 4)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }
            return prime;
        }
    }
}