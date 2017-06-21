using System;
using System.Linq;

namespace TriFunction
{
    internal class Program
    {
        private static void Main()
        {
            Func<int, string, bool> CharSum = (sum, name) =>
            {
                int temp = 0;

                foreach (char c in name)
                {
                    temp += c;
                }

                return temp >= sum;
            };

            int maxSum = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Join(" ", Console.ReadLine()
                .Split(' ')
                .Where(n => CharSum(maxSum, n))));
        }
    }
}