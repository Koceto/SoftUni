using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var squareNumbers = new List<int>();

            foreach (var digit in numbers)
            {
                var squareDigit = Math.Sqrt(digit);

                if (squareDigit == (int)squareDigit)
                {
                    squareNumbers.Add(digit);
                }
            }
            squareNumbers.Sort();
            squareNumbers.Reverse();

            Console.WriteLine(string.Join(" ", squareNumbers));

        }
    }
}
