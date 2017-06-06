using System.Linq;

namespace Diagonal_Difference
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var matrix = new int[n][];
            var differenceInDiagonals = default(long);

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[i] = input;
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                differenceInDiagonals += matrix[i][i];
                differenceInDiagonals -= matrix[i][matrix[i].Length - 1 - i];
            }

            Console.WriteLine(Math.Abs(differenceInDiagonals));
        }
    }
}