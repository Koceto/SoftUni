using System;
using System.Linq;

namespace Magic_exchangeable_words
{
    public static class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split();
            var firstWord = input[0]
                .Distinct()
                .ToArray();
            var secondWord = input[1]
                .Distinct()
                .ToArray();
            var firstWordCheck = CheckWord(firstWord);
            var secondWordCheck = CheckWord(secondWord);

            if (firstWordCheck.Length <= secondWordCheck.Length &&
                firstWordCheck.SequenceEqual(secondWordCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static bool[] CheckWord(char[] word)
        {
            var checkedWord = new bool[word.Length];

            for (int i = 1; i < word.Length; i++)
            {
                var previous = i - 1;
                var current = i;

                if (word[current] == word[previous])
                {
                    checkedWord[previous] = true;
                    checkedWord[current] = true;
                }
                else
                {
                    checkedWord[current] = false;
                }
            }
            return checkedWord;
        }
    }
}