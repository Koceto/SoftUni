using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Increasing_Subsequence
{
    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var longestSeq = FindLongestIncreasingSubsequence(numbers);

            Console.WriteLine(string.Join(" ", longestSeq));
        }

        public static int[] FindLongestIncreasingSubsequence(int[] numbers)
        {
            var length = new int[numbers.Length];
            var previous = new int[numbers.Length];
            var longestSeq = new List<int>();
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                length[i] = 1;
                previous[i] = -1;
                //11 12 13 3 14 4 15 5 6 7 8 7 16 9 8
                for (int a = 0; a < i; a++)
                {
                    if (numbers[a] < numbers[i] && length[a] >= length[i])
                    {
                        length[i]++;
                        previous[i] = a;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    lastIndex = i;
                }
            }

            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(numbers[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            longestSeq.Reverse();
            return longestSeq.ToArray();
        }
    }
}