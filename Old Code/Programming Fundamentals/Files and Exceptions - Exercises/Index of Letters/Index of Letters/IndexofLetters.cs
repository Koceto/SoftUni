using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Index_of_Letters
{
    public class IndexofLetters
    {
        public static void Main()
        {
            var filePath = @"..\..\";
            var input = File.ReadAllText(filePath + "input.txt")
                .Trim()
                .ToCharArray();
            var result = new Dictionary<char, int>();

            foreach (var symbol in input)
            {
                if (char.IsLetter(symbol))
                {
                    result[symbol] = (int)symbol;
                }
            }

            File.WriteAllText(filePath + "result.txt", string.Join(Environment.NewLine, result.Select(x => $"{x.Key} -> {x.Value - 'a'}")));
        }
    }
}
