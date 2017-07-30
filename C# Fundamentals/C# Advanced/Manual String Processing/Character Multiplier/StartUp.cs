using System;

namespace Character_Multiplier
{
    public static class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Trim()
                .Split(' ');
            var firstWord = input[0];
            var secondWord = input[1];
            var sum = 0L;

            for (int i = 0; i < Math.Max(firstWord.Length, secondWord.Length); i++)
            {
                var isFirstLongEnough = i < firstWord.Length;
                var isSecondLongEnough = i < secondWord.Length;

                if (isFirstLongEnough && isSecondLongEnough)
                {
                    sum += firstWord[i] * secondWord[i];
                }
                else if (!isFirstLongEnough)
                {
                    sum += secondWord[i];
                }
                else
                {
                    sum += firstWord[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}