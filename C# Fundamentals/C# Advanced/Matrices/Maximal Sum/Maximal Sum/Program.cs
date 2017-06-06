namespace Maximal_Sum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var bigmatrix = new int[dimentions.First()][];
            var resultMatrix = new int[3][];
            var totalSum = long.MinValue;

            for (int i = 0; i < dimentions.First(); i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                bigmatrix[i] = new int[dimentions.Last()];
                bigmatrix[i] = input;
            }

            for (int rowIndex = 0; rowIndex < bigmatrix.Length - 2; rowIndex++)
            {
                var currMatrix = new int[3][];

                for (int colIndex = 0; colIndex < bigmatrix[rowIndex].Length - 2; colIndex++)
                {
                    currMatrix[0] = bigmatrix[rowIndex].Skip(colIndex).Take(3).ToArray();
                    currMatrix[1] = bigmatrix[rowIndex + 1].Skip(colIndex).Take(3).ToArray();
                    currMatrix[2] = bigmatrix[rowIndex + 2].Skip(colIndex).Take(3).ToArray();

                    var currSum = currMatrix[0].Sum() + currMatrix[1].Sum() + currMatrix[2].Sum();

                    if (currSum > totalSum)
                    {
                        totalSum = currSum;

                        resultMatrix[0] = currMatrix[0];
                        resultMatrix[1] = currMatrix[1];
                        resultMatrix[2] = currMatrix[2];
                    }
                }
            }

            Console.WriteLine($"Sum = {totalSum}");

            foreach (var row in resultMatrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}