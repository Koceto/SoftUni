namespace Portal
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Location
    {
        public int Cell { get; set; }

        public int Layer { get; set; }
    }

    public class GLaDOS
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var grid = new List<List<char>>();
            var turnsNeeded = default(int);

            for (int i = 0; i < n; i++)
            {
                var currInput = Console.ReadLine()
                    .ToCharArray()
                    .ToList();

                grid.Add(currInput);
            }

            var command = Console.ReadLine()
                .ToCharArray()
                .ToList();
            var location = new Location();

            foreach (var direction in command)
            {
                turnsNeeded++;

                switch (direction)
                {
                    case 'L':

                        location = FindTheLocation(grid);
                        var leftCell = location.Cell - 1;

                        if (leftCell < 0)
                        {
                            leftCell = grid[location.Layer].Count - 1;
                        }

                        if (grid[location.Layer][leftCell] == 'E')
                        {
                            Console.WriteLine($"Experiment successful. {turnsNeeded} turns required.");
                            return;
                        }
                        else
                        {
                            grid[location.Layer].RemoveAt(location.Cell);
                            grid[location.Layer].Insert(location.Cell, 'O');
                            grid[location.Layer].RemoveAt(leftCell);
                            grid[location.Layer].Insert(leftCell, 'S');
                        }

                        location.Cell = leftCell;

                        break;
                    case 'R':

                        location = FindTheLocation(grid);

                        var rightCell = location.Cell + 1;

                        if (rightCell > grid[location.Layer].Count - 1)
                        {
                            rightCell = 0;
                        }

                        if (grid[location.Layer][rightCell] == 'E')
                        {
                            Console.WriteLine($"Experiment successful. {turnsNeeded} turns required.");
                            return;
                        }
                        else
                        {
                            grid[location.Layer].RemoveAt(location.Cell);
                            grid[location.Layer].Insert(location.Cell, 'O');
                            grid[location.Layer].RemoveAt(rightCell);
                            grid[location.Layer].Insert(rightCell, 'S');
                        }

                        location.Cell = rightCell;

                        break;
                    case 'U':

                        location = FindTheLocation(grid);
                        var layerAbove = location.Layer - 1;

                        if (layerAbove < 0)
                        {
                            layerAbove = grid.Count - 1;
                        }

                        while (location.Cell > grid[layerAbove].Count - 1)
                        {
                            layerAbove--;

                            if (layerAbove < 0)
                            {
                                layerAbove = grid.Count - 1;
                            }
                        }

                        if (grid[layerAbove][location.Cell] == 'E')
                        {
                            Console.WriteLine($"Experiment successful. {turnsNeeded} turns required.");
                            return;
                        }
                        else
                        {
                            grid[location.Layer].RemoveAt(location.Cell);
                            grid[location.Layer].Insert(location.Cell, 'O');
                            grid[layerAbove].RemoveAt(location.Cell);
                            grid[layerAbove].Insert(location.Cell, 'S');
                        }

                        location.Layer = layerAbove;

                        break;
                    case 'D':

                        location = FindTheLocation(grid);
                        var layerBellow = (location.Layer + 1) % grid.Count;

                        while (location.Cell > grid[layerBellow].Count - 1)
                        {
                            layerBellow++;

                            if (layerBellow > grid.Count - 1)
                            {
                                layerBellow = 0;
                            }
                        }

                        if (grid[layerBellow][location.Cell] == 'E')
                        {
                            Console.WriteLine($"Experiment successful. {turnsNeeded} turns required.");
                            return;
                        }
                        else
                        {
                            grid[location.Layer].RemoveAt(location.Cell);
                            grid[location.Layer].Insert(location.Cell, 'O');
                            grid[layerBellow].RemoveAt(location.Cell);
                            grid[layerBellow].Insert(location.Cell, 'S');
                        }

                        location.Layer = layerBellow;

                        break;
                }
            }

            location = FindTheLocation(grid);

            Console.WriteLine($"Robot stuck at {location.Layer} {location.Cell}. Experiment failed.");
        }

        private static Location FindTheLocation(List<List<char>> grid)
        {
            var location = new Location();

            foreach (var col in grid)
            {
                foreach (char row in col)
                {
                    if (row == 'S')
                    {
                        location.Layer = grid.IndexOf(col);
                        location.Cell = col.IndexOf(row);
                        return location;
                    }
                }
            }

            return location;
        }
    }
}