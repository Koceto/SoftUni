using System.Linq;

namespace Squares_in_Matrix
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new char[dimentions.First()][];
            var numberOfSquares = default(int);

            for (int i = 0; i < dimentions.First(); i++)
            {
                var input = string.Join("", Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    .ToCharArray();


                matrix[i] = new char[input.Length];
                matrix[i] = input;
            }

            for (int rowIndex = 0; rowIndex < matrix.Length - 1; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length - 1; colIndex++)
                {
                    var topLeft = matrix[rowIndex][colIndex];
                    var topRight = matrix[rowIndex][colIndex + 1];
                    var bottomLeft = matrix[rowIndex + 1][colIndex];
                    var bottomRight = matrix[rowIndex + 1][colIndex + 1];

                    if (topLeft == topRight && topLeft == bottomLeft && topLeft == bottomRight)
                    {
                        numberOfSquares++;
                    }
                }
            }

            Console.WriteLine(numberOfSquares);
        }
    }
}