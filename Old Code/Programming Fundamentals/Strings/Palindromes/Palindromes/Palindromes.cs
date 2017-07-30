namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries);
            var result = new HashSet<string>();

            foreach (var word in text)
            {
                var reversed = string.Join("", word.Reverse());

                if (word == reversed)
                {
                    result.Add(string.Join("", word));
                }
            }
            Console.WriteLine(string.Join(", ", result.OrderBy(x => x)));

        }
    }
}
