namespace LadyBugs
{
    using System;
    using System.Linq;

    public class BugArray
    {
        static void Main()
        {
            var field = new int[int.Parse(Console.ReadLine())];
            var bugPlaces = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            var command = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int fieldSpot = 0; fieldSpot < field.Length; fieldSpot++)
            {
                if (bugPlaces.Contains(fieldSpot))
                {
                    field[fieldSpot] = 1;
                }
            }

            while (command[0] != "end")
            {
                int position = int.Parse(command[0]);
                var direction = command[1];
                int length = int.Parse(command[2]);

                if (((direction == "right" && length > 0) || (direction == "left" && length < 0)) && position >= 0 && position < field.Length)
                {
                    length = Math.Abs(length);

                    if (position + length > field.Length - 1)
                    {
                        field[position] = 0;
                    }
                    else if (field[position] == 1 && field[position + length] == 0)
                    {
                        field[position + length] = 1;
                        field[position] = 0;
                    }
                    else if (field[position] == 1 && field[position + length] == 1)
                    {
                        var prevPos = position + length;

                        while (true)
                        {
                            var currPos = prevPos + length;

                            if (currPos < field.Length)
                            {
                                if (field[currPos] == 0)
                                {
                                    field[currPos] = 1;
                                    field[position] = 0;
                                    break;
                                }
                            }
                            else
                            {
                                field[position] = 0;
                                break;
                            }
                            prevPos = currPos;
                        }
                    }
                }
                else if (((direction == "left" && length > 0) || (direction == "right" && length < 0)) && position >= 0 && position < field.Length)
                {
                    length = Math.Abs(length);

                    if (position - length < 0)
                    {
                        field[position] = 0;
                    }
                    else if (field[position] == 1 && field[position - length] == 0)
                    {
                        field[position - length] = 1;
                        field[position] = 0;
                    }
                    else if (field[position] == 1 && field[position - length] == 1)
                    {
                        var prevPos = position - length;

                        while (true)
                        {
                            var currPos = prevPos - length;

                            if (currPos >= 0)
                            {
                                if (field[currPos] == 0)
                                {
                                    field[currPos] = 1;
                                    field[position] = 0;
                                    break;
                                }
                            }
                            else
                            {
                                field[position] = 0;
                                break;
                            }
                            prevPos = currPos;
                        }
                    }
                }
                command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}