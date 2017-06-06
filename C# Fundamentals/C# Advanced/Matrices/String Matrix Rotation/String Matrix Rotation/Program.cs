using System;
using System.Collections.Generic;
using System.Linq;

namespace String_Matrix_Rotation
{
    public class Program
    {
        public static void Main()
        {
            var rotateDegree = Console.ReadLine()
                .Trim()
                .Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            var input = string.Empty;
            var longestWord = 0;
            var words = new List<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                words.Add(input);

                if (input.Length > longestWord)
                {
                    longestWord = input.Length;
                }
            }

            var degrees = int.Parse(rotateDegree.Last());

            while (degrees >= 360)
            {
                degrees -= 360;
            }

            switch (degrees)
            {
                case 0:
                    PrintWords(words, "normal");
                    break;

                case 90:
                    RotateAndPrint(words, "normal", longestWord);
                    break;

                case 180:
                    PrintWords(words, "inverted");
                    break;

                case 270:
                    RotateAndPrint(words, "inverted", longestWord);
                    break;
            }
        }

        private static void RotateAndPrint(List<string> words, string printType, int longestWord)
        {
            if (printType == "normal")
            {
                for (int colIndex = 0; colIndex < longestWord; colIndex++)
                {
                    for (int rowIndex = words.Count - 1; rowIndex >= 0; rowIndex--)
                    {
                        if (words[rowIndex].Length > colIndex)
                        {
                            Console.Write(words[rowIndex][colIndex]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else if (printType == "inverted")
            {
                for (int colIndex = longestWord - 1; colIndex >= 0; colIndex--)
                {
                    for (int rowIndex = 0; rowIndex < words.Count; rowIndex++)
                    {
                        if (words[rowIndex].Length > colIndex)
                        {
                            Console.Write(words[rowIndex][colIndex]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void PrintWords(List<string> words, string printType)
        {
            if (printType == "normal")
            {
                foreach (var word in words)
                {
                    Console.WriteLine(word);
                }
            }
            else if (printType == "inverted")
            {
                for (int i = words.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(string.Join("", words[i].ToCharArray().Reverse()));
                }
            }
        }
    }
}