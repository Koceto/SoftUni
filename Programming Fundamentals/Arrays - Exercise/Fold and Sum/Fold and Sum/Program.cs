using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    public class Program
    {
        public static void Main()
        {
            string temp = Console.ReadLine();
            var number = temp.Split(' ').Select(int.Parse).ToArray();
            var firstLine = new int[number.Length / 2];
            var secondLine = new int[number.Length / 2];
            var result = new int[firstLine.Length];

            for (int i = 0; i < firstLine.Length / 2; i++)
            {
                firstLine[i] = number[number.Length / 4 - i - 1];
                firstLine[firstLine.Length - i - 1] = number[number.Length + i - firstLine.Length / 2];

                secondLine[i] = number[i + firstLine.Length / 2];
                secondLine[secondLine.Length - i - 1] = number[number.Length - i - 1 - firstLine.Length / 2];
            }

            for (int i = 0; i < firstLine.Length; i++)
            {
                result[i] = firstLine[i] + secondLine[i];
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
