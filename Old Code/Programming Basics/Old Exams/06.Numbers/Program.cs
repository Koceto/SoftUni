using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstNumber = n / 100;
            int secondNumber = (n / 10) % 10;
            int thirdNumber = n % 10;

            int rows = firstNumber + secondNumber;
            int cols = firstNumber + thirdNumber;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0} ", (n % 5 == 0 ? n -= firstNumber :
                        n % 3 == 0 ? n -= secondNumber :
                        n += thirdNumber));
                }
                Console.WriteLine();
            }
        }
    }
}
