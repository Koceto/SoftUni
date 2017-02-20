using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Increasing_Elements
{
    public class IncreasingSequenceOfElements
    {
        public static void Main()
        {
            string temp = Console.ReadLine();
            var numbers = temp.Split(' ').Select(int.Parse).ToArray();
            var result = new string[numbers.Length];
            int compare = numbers[0];
            int length = 1;
            int maxLength = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - compare >= 1)
                {
                    length++;
                }
                else
                {
                    length = 1;
                }
                compare = numbers[i];

                if (maxLength < length)
                {
                    maxLength = length;

                    for (int compareIndex = 0; compareIndex < maxLength; compareIndex++)
                    {
                        result[compareIndex] = numbers[i + 1 - maxLength + compareIndex].ToString();
                    }
                }

            }
            Console.WriteLine(string.Join(" ", result).Trim());

        }
    }
}
