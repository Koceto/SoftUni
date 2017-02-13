using System;
using System.IO;
using System.Linq;

namespace Max_Sequenc_Of_Equal_Elements
{
    public class MaxSequenceofEqualElements
    {
        public static void Main()
        {
            var filePath = @"..\..\";
            var numbers = File.ReadAllText(filePath + "input.txt")
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var count = 1;
            var maxCount = 1;
            var mostCommonnumber = 0;

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                var previous = numbers[i - 1];
                var current = numbers[i];

                if (previous == current)
                {
                    count++;
                    i++;
                }
                else
                {
                    count = 1;
                }

                if (maxCount < count)
                {
                    maxCount = count;
                    mostCommonnumber = previous;
                }
            }

            var result = new int[maxCount];

            for (int i = 0; i < maxCount; i++)
            {
                result[i] = mostCommonnumber;
            }

            Console.WriteLine(string.Join(" ", result));
            File.WriteAllText(filePath + "result.txt", string.Join(" ", result));
        }
    }
}
