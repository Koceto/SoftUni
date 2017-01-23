using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    public class Program
    {
        public static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = 0;
            int oddResult = 0;
            int evenResult = 0;

            foreach (char symbol in number.ToString())
            {
                int digit = symbol - '0';
                result = digit % 2 == 0 ?
                    oddResult += digit :
                    evenResult += digit;
            }

            Console.WriteLine(oddResult * evenResult);
        }
    }
}
