using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    public class Program
    {
        public static void Main()
        {
            string temp = Console.ReadLine();
            int timesToRotate = int.Parse(Console.ReadLine());
            var numbers = temp.Split(' ').Select(int.Parse).ToArray();
            var result = new int[numbers.Length];

            for (int i = 0; i < timesToRotate; i++)
            {
                int lastDigit = numbers[numbers.Length - 1];

                for (int si = numbers.Length - 1; si > 0; si--)
                {
                    numbers[si] = numbers[si - 1];
                }

                numbers[0] = lastDigit;

                for (int ti = 0; ti < numbers.Length; ti++)
                {
                    result[ti] += numbers[ti];
                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}