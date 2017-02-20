using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    public class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetBigger(firstNumber, secondNumber, thirdNumber));
        }

        private static int GetBigger(int firstNumber, int secondNumber, int thirdNumber)
        {
            int number = Math.Max(firstNumber, secondNumber);
            return Math.Max(number, thirdNumber);
        }
    }
}
