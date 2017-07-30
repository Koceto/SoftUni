namespace TrifonsQuest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Location
    {
        public int Row { get; set; }

        public int Col { get; set; }
    }

    public class TheQuest
    {
        public static void Main()
        {
            var health = int.Parse(Console.ReadLine());
            var mapSize = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var map = new List<List<char>>();

            for (int i = 0; i < mapSize.First(); i++)
            {
                map.Add(Console.ReadLine().ToCharArray().ToList());
            }

            var currPos = new Location
            {
                Row = 0,
                Col = 0
            };
            var exit = new Location();
            var turnsCount = default(int);

            if (map[0].Count % 2 == 0)
            {
                exit.Col = map[0].Count - 1;
                exit.Row = 0;
            }
            else
            {
                exit.Col = map[0].Count - 1;
                exit.Row = map.Count - 1;
            }

            var completed = false;

            while (health > 0)
            {
                // goes DOWN
                if (currPos.Col % 2 == 0)
                {
                    // Is NOT last cell
                    if (currPos.Row != map.Count - 1)
                    {
                        switch (map[currPos.Row][currPos.Col])
                        {
                            case 'F':
                                health -= turnsCount / 2;
                                currPos.Row += health <= 0 ? 0 : 1;
                                break;
                            case 'H':
                                health += turnsCount / 3;
                                currPos.Row += 1;
                                break;
                            case 'T':
                                turnsCount += 2;
                                currPos.Row += 1;
                                break;
                            default:
                                currPos.Row += 1;
                                break;
                        }
                    }
                    // Is last cell
                    else
                    {
                        switch (map[currPos.Row][currPos.Col])
                        {
                            case 'F':
                                health -= turnsCount / 2;
                                currPos.Col += IsAtExit(currPos, exit) || health <= 0 ? 0 : 1;
                                break;
                            case 'H':
                                health += turnsCount / 3;
                                currPos.Col += IsAtExit(currPos, exit) ? 0 : 1;
                                break;
                            case 'T':
                                turnsCount += 2;
                                currPos.Col += IsAtExit(currPos, exit) ? 0 : 1;
                                break;
                            default:
                                currPos.Col += IsAtExit(currPos, exit) ? 0 : 1;
                                break;
                        }
                    }
                }
                // goes UP
                else
                {
                    // Is NOT last cell
                    if (currPos.Row > 0)
                    {
                        switch (map[currPos.Row][currPos.Col])
                        {
                            case 'F':
                                health -= turnsCount / 2;
                                currPos.Row -= health <= 0 ? 0 : 1;
                                break;
                            case 'H':
                                health += turnsCount / 3;
                                currPos.Row -= 1;
                                break;
                            case 'T':
                                turnsCount += 2;
                                currPos.Row -= 1;
                                break;
                            default:
                                currPos.Row -= 1;
                                break;
                        }
                    }
                    // Is last cell
                    else
                    {
                        switch (map[currPos.Row][currPos.Col])
                        {
                            case 'F':
                                health -= turnsCount / 2;
                                currPos.Col += IsAtExit(currPos, exit) || health <= 0 ? 0 : 1;
                                break;
                            case 'H':
                                health += turnsCount / 3;
                                currPos.Col += IsAtExit(currPos, exit) ? 0 : 1;
                                break;
                            case 'T':
                                turnsCount += 2;
                                currPos.Col += IsAtExit(currPos, exit) ? 0 : 1;
                                break;
                            default:
                                currPos.Col += IsAtExit(currPos, exit) ? 0 : 1;
                                break;
                        }
                    }
                }
                turnsCount++;

                if (completed)
                {
                    break;
                }

                if (IsAtExit(currPos, exit) && !completed)
                {
                    completed = true;
                }
            }

            if (health > 0)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine($"Health: {health}");
                Console.WriteLine($"Turns: {turnsCount}");
            }
            else
            {
                Console.WriteLine($"Died at: [{currPos.Row}, {currPos.Col}]");
            }
        }

        private static bool IsAtExit(Location currPos, Location exit)
        {
            if (currPos.Col == exit.Col && currPos.Row == exit.Row)
            {
                return true;
            }
            return false;
        }
    }
}
