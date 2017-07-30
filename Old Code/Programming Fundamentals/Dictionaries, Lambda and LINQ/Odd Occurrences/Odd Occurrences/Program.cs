using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    public class OddOccurences
    {
        public static void Main()
        {
            var sentence = Console.ReadLine()
                .ToLower()
                .Split(' ');

            var dict = new Dictionary<string, int>();
            var result = new List<string>();

            foreach (var word in sentence)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 0;
                }
                dict[word]++;
            }

            foreach (var item in dict)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
