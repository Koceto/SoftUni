using System;
using System.Globalization;

namespace Formatting_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var firstNumber = int.Parse(input[0], CultureInfo.InvariantCulture);
            var secondNumber = double.Parse(input[1], CultureInfo.InvariantCulture);
            var thirdNumber = double.Parse(input[2], CultureInfo.InvariantCulture);
            var stringFormat = "|{0,-10}|{1}|{2,10:f2}|{3,-10:f3}|"; //|FE        |0011111110|     11.60|0.500     |

            var firstResult = firstNumber.ToString("X");
            var secondResult = Convert.ToString(firstNumber, 2);
            Console.WriteLine(stringFormat, firstResult, secondResult.PadLeft(10, '0').Substring(0, 10), secondNumber, thirdNumber);
        }
    }
}