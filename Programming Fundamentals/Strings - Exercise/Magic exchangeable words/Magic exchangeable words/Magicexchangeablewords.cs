namespace Magic_exchangeable_words
{
    using System;
    using System.Linq;

    public class Magicexchangeablewords
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split();
            var firstWord = input[0]
                .ToCharArray();
            var secondWord = input[1]
                .ToCharArray();
            var firstWordCheck = CheckWord(firstWord);
            var secondWordCheck = CheckWord(secondWord);

            if (Enumerable.SequenceEqual(firstWordCheck, secondWordCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (firstWord.Length > secondWord.Length)
                {
                    var firstWordSecondCheck = CheckWord(firstWord.Distinct().ToArray());

                    if (Enumerable.SequenceEqual(firstWordSecondCheck, secondWordCheck))
                    {
                        Console.WriteLine("true");
                        return;
                    }
                }
                else
                {
                    var secondWordSecondCheck = CheckWord(secondWord.Distinct().ToArray());

                    if (Enumerable.SequenceEqual(secondWordSecondCheck, firstWordCheck))
                    {
                        Console.WriteLine("true");
                        return;
                    }
                }
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