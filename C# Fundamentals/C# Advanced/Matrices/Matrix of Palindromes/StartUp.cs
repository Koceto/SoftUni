using System;
using System.Linq;

namespace Matrix_of_Palindromes
{
    public static class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new string[input.First()][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new string[input.Last()];
                matrix[i] = FillWithPalidromes(i + 'a', input.Last());
            }

            foreach (var palidrom in matrix)
            {
                Console.WriteLine(String.Join(" ", palidrom));
            }
        }

        public static string[] FillWithPalidromes(int i, int numberOfPalidromes)
        {
            var letter = (char)i;
            var palidromes = new string[numberOfPalidromes];

            for (int letterIndex = 0; letterIndex < numberOfPalidromes; letterIndex++)
            {
                var currPalidrom = string.Join("", letter, (char)(letterIndex + letter), letter);

                palidromes[letterIndex] = currPalidrom;
            }

            return palidromes;
        }
    }
}