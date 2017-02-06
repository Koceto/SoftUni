using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    public class FrequentNumber
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var numbers = input.Split(' ').Select(int.Parse).ToArray();
            int resullt = 0;
            int length = 1;
            int maxLength = 1;
            bool safe = false;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = a + 1; b < numbers.Length; b++)
                {
                    if (numbers[a] == numbers[b])
                    {
                        length++;
                        safe = true;
                    }
                    else
                    {
                        length = 1;
                    }

                    if (maxLength < length)
                    {
                        maxLength = length;
                        resullt = numbers[a];
                    }
                }
                length = 1;

            }
            if (!safe)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                Console.WriteLine(resullt);
            }

        }
    }
}
