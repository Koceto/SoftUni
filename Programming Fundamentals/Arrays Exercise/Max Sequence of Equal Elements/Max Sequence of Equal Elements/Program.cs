using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    public class CharSequence
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
                if (numbers[i] == compare)
                {
                    length++;
                }
                else
                {
                    length = 1;
                    compare = numbers[i];
                }
                if (maxLength < length)
                {
                    maxLength = length;

                    for (int compareIndex = i; compareIndex < i + maxLength; compareIndex++)
                    {
                        result[compareIndex - i] = numbers[i].ToString();
                    }
                }

            }
            Console.WriteLine(string.Join(" ", result).Trim());

        }
    }
}
