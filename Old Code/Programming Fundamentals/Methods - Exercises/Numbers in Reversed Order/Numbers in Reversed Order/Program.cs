using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Reversed_Order
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(ReverseNumbers(Console.ReadLine()));
        }

        private static string ReverseNumbers(string number)
        {
            string result = string.Empty;

            foreach (char symbol in number)
            {
                char digit = symbol;
                result = digit + result;
            }
            return result;
        }
    }
}
