using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNumber = int.Parse(Console.ReadLine());

            if (intNumber > 0)
            {
                NumberIsBiggerThanZero(intNumber);
            }
            else if (intNumber < 0)
            {
                NumberIsLessThanZero(intNumber);
            }
            else
            {
                NumberIsZero(intNumber);
            }
        }

        private static void NumberIsZero(int intNumber)
        {
            Console.WriteLine($"The number {intNumber} is zero.");
        }

        private static void NumberIsLessThanZero(int intNumber)
        {
            Console.WriteLine($"The number {intNumber} is negative.");
        }

        private static void NumberIsBiggerThanZero(int intNumber)
        {
            Console.WriteLine($"The number {intNumber} is positive.");
        }
    }
}
