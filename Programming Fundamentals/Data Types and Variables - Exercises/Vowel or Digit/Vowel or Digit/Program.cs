using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            int digit = 0;
            bool digits = int.TryParse(symbol, out digit);
            symbol = symbol.ToLower();

            if (digits)
            {
                Console.WriteLine("digit");
            }
            else if (symbol == "a" || symbol == "o" || symbol == "i" || symbol == "e" || symbol == "u")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
