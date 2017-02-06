using System;
using System.Collections.Generic;
using System.Linq;

namespace Short_Words_Sorted
{
    public class SortShortWords
    {
        public static void Main()
        {
            var sentence = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', ' ', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w);

            Console.WriteLine(string.Join(", ", sentence));
        }
    }
}
