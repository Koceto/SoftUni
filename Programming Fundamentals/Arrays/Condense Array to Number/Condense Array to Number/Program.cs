using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condense_Array_to_Number
{
    public class ArrayToNumber
    {
        public static void Main()
        {
            string numbers = Console.ReadLine();

            var numbersToSum = numbers.Split(' ').Select(int.Parse).ToArray();

            while (numbersToSum.Length > 1)
            {
                var temp = new int[numbersToSum.Length - 1];

                for (int i = 0; i < numbersToSum.Length - 1; i++)
                {
                    temp[i] = numbersToSum[i] + numbersToSum[i + 1];
                }
                numbersToSum = temp;
            }
            Console.WriteLine(string.Join(" ", numbersToSum));

        }
    }
}
