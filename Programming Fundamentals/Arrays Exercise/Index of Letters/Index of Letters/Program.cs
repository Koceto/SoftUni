using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var letters = input.ToArray();
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToArray();

            for (int a = 0; a < letters.Length; a++)
            {
                for (int b = 0; b < alphabet.Length; b++)
                {
                    if (letters[a] == alphabet[b])
                    {
                        Console.WriteLine($"{letters[a]} -> {b}");
                    }
                }
            }
        }
    }
}
