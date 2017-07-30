namespace TargetMultiplier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Location
    {
        public int Row { get; set; }

        public int Col { get; set; }
    }

    public class WorldsMostUselessCalculator
    {
        public static void Main()
        {
            var size = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var field = new List<List<long>>();

            var fieldSize = new Location
            {
                Col = size.Last(),
                Row = size.First()
            };

            for (int i = 0; i < fieldSize.Row; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                field.Add(new List<long>());
                field[i].AddRange(input);
            }

            var targetInfo = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var target = new Location
            {
                Col = targetInfo.Last(),
                Row = targetInfo.First()
            };

            var neighbors = default(long);

            var targetValue = field[target.Row][target.Col];
            var topLeft = field[target.Row - 1][target.Col - 1];
            var midLeft = field[target.Row][target.Col - 1];
            var bottomLeft = field[target.Row + 1][target.Col - 1];
            var topMid = field[target.Row - 1][target.Col];
            var bottomMid = field[target.Row + 1][target.Col];
            var topRight = field[target.Row - 1][target.Col + 1];
            var midRight = field[target.Row][target.Col + 1];
            var bottomRight = field[target.Row + 1][target.Col + 1];

            neighbors = topLeft + topMid + topRight + midLeft + midRight + bottomLeft + bottomMid + bottomRight;

            field[target.Row][target.Col] = targetValue * neighbors;
            field[target.Row - 1][target.Col - 1] *= targetValue;
            field[target.Row][target.Col - 1] *= targetValue;
            field[target.Row + 1][target.Col - 1] *= targetValue;
            field[target.Row - 1][target.Col] *= targetValue;
            field[target.Row + 1][target.Col] *= targetValue;
            field[target.Row - 1][target.Col + 1] *= targetValue;
            field[target.Row][target.Col + 1] *= targetValue;
            field[target.Row + 1][target.Col + 1] *= targetValue;

            foreach (var row in field)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
