namespace LadybugsTheSecond
{
    using System;
    using System.Linq;

    public class MenBugs
    {
        public static void Main()
        {
            var field = new int[int.Parse(Console.ReadLine())];
            var bugs = Console.ReadLine()
                .Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .TakeWhile(bi => bi < field.Length && bi > 0)
                .ToArray();

            for (int i = 0; i < field.Length; i++)
            {
                if (bugs.Contains(i))
                {
                    field[i] = 1;
                }
            }

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (input.First() == "end")
                {
                    break;
                }

                var bugIndex = int.Parse(input.First());
                var flightLength = int.Parse(input.Last());
                var flightDirection = input[1];

                if (bugIndex < 0
                    || bugIndex > field.Length - 1
                    || field[bugIndex] == 0)
                {
                    continue;
                }

                if ((flightDirection.ToLower() == "right" && flightLength > 0) 
                    || (flightDirection.ToLower() == "left" && flightLength < 0))
                {
                    var fieldToLand = bugIndex + Math.Abs(flightLength);

                    if (fieldToLand > field.Length - 1)
                    {
                        field[bugIndex] = 0;
                    }
                    else if (field[fieldToLand] == 1)    //Flying to the RIGHT
                    {
                        while (true)
                        {
                            if (fieldToLand > field.Length - 1)
                            {
                                field[bugIndex] = 0;
                                break;
                            }
                            else if (field[fieldToLand] == 0 && fieldToLand <= field.Length - 1)
                            {
                                field[bugIndex] = 0;
                                field[fieldToLand] = 1;
                                break;
                            }

                            fieldToLand += flightLength;
                        }
                    }
                    else
                    {
                        field[bugIndex] = 0;
                        field[fieldToLand] = 1;
                    }
                }
                else    //Flying to the LEFT
                {
                    var fieldToLand = bugIndex - Math.Abs(flightLength);

                    if (fieldToLand < 0)
                    {
                        field[bugIndex] = 0;
                    }
                    else if (field[fieldToLand] == 1)
                    {
                        while (true)
                        {
                            if (fieldToLand < 0)
                            {
                                field[bugIndex] = 0;
                                break;
                            }
                            else if (field[fieldToLand] == 0 && fieldToLand >= 0)
                            {
                                field[bugIndex] = 0;
                                field[fieldToLand] = 1;
                                break;
                            }

                            fieldToLand -= flightLength;
                        }
                    }
                    else
                    {
                        field[bugIndex] = 0;
                        field[fieldToLand] = 1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
