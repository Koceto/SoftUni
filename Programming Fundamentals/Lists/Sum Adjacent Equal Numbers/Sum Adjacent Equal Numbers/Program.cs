using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int i = 1;

            while (i != numbers.Count)
            {
                for (; i < numbers.Count; i++)
                {
                    double next = numbers[i];
                    double previous = numbers[i - 1];

                    if (previous == next)
                    {
                        numbers[i - 1] += numbers[i];
                        numbers.RemoveAt(i);
                        i = 1;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}

