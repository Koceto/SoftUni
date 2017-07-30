using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    public static class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var symbols = new SortedDictionary<char, int>();

            foreach (char currChar in input)
            {
                if (symbols.ContainsKey(currChar))
                {
                    symbols[currChar]++;
                }
                else
                {
                    symbols.Add(currChar, 1);
                }
            }

            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}