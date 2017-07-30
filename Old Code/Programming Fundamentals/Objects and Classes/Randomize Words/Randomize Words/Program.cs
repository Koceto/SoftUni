using System;
using System.Linq;

namespace Randomize_Words
{
    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split()
                .ToList();
            var random = new Random();

            for (int i = 0; i < words.Count - 1; i++)
            {
                var temp = words[i];
                words.Remove(words[i]);
                words.Insert(random.Next(0, words.Count), temp);
            }

            words.ForEach(Console.WriteLine);
        }

    }
}
