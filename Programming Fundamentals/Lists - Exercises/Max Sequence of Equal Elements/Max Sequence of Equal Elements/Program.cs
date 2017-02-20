using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Add(int.MaxValue);
            int previous = numbers[0];
            int length = 1;
            int maxLength = 1;
            int endOfLongestSequense = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                int next = numbers[i];

                if (next == previous)
                {
                    length++;
                }
                else
                {
                    length = 1;
                    previous = next;
                }

                if (maxLength < length)
                {
                    maxLength = length;
                    endOfLongestSequense = i;
                }
            }

            for (int i = endOfLongestSequense; i > endOfLongestSequense - maxLength; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
