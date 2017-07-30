using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs_by_Difference
{
    public class PairsByDifference
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int difference = int.Parse(Console.ReadLine());
            var numbers = input.Split(' ').Select(int.Parse).ToArray();
            int result = 0;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = a; b < numbers.Length; b++)
                {
                    if (numbers[a] + difference == numbers[b] || numbers[a] - difference == numbers[b])
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);

        }
    }
}
