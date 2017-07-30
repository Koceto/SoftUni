using System;
using System.Collections.Generic;

namespace Palindromes
{
    public static class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '\t', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var words = new SortedSet<string>();

            foreach (var word in text)
            {
                if (word.Length == 1)
                {
                    words.Add(word);
                    break;
                }

                for (int i = 0; i < word.Length / 2; i++)
                {
                    var lastIndex = word.Length - 1 - i;

                    if (word[i] != word[lastIndex])
                    {
                        break;
                    }
                    else if (i == word.Length / 2 - 1)
                    {
                        words.Add(word);
                    }
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", words));
        }
    }
}