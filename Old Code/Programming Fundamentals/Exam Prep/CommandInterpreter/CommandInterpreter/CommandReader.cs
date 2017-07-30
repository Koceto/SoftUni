namespace CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandReader
    {
        public static void Main()
        {
            var data = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (input.First() == "end")
                {
                    break;
                }

                var command = input.First();
                var startIndex = default(int);
                var count = default(int);

                if (command == "reverse")
                {
                    startIndex = int.Parse(input[2]);
                    count = int.Parse(input[4]);

                    if (InvalidNumbers(startIndex, count, data))
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    };

                    DataReverse(startIndex, count, data);
                }
                else if (command == "sort")
                {
                    startIndex = int.Parse(input[2]);
                    count = int.Parse(input[4]);

                    if (InvalidNumbers(startIndex, count, data))
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    };

                    DataSort(startIndex, count, data);
                }
                else if (command.ToLower() == "rollleft")
                {
                    count = int.Parse(input[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    };

                    DataRollLeft(count, data);
                }
                else if (command.ToLower() == "rollright")
                {
                    count = int.Parse(input[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    };

                    DataRollRight(count, data);
                }
            }
            Console.WriteLine("[{0}]",
                string.Join(", ", data));
        }

        private static bool InvalidNumbers(int startIndex, int count, List<string> data)
        {
            if (startIndex < 0 || startIndex >= data.Count || count < 0 || (startIndex + count) > data.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void DataRollRight(int count, List<string> data)
        {
            var repeat = count % data.Count;

            for (int i = 0; i < repeat; i++)
            {
                var element = data.Last();
                data.RemoveAt(data.Count - 1);
                data.Insert(0, element);
            }
        }

        private static void DataRollLeft(int count, List<string> data)
        {
            var repeat = count % data.Count;

            for (int i = 0; i < repeat; i++)
            {
                var element = data[0];
                data.RemoveAt(0);
                data.Add(element);
            }
        }

        private static void DataSort(int startIndex, int count, List<string> data)
        {
            var tempList = data
                .Skip(startIndex)
                .Take(count)
                .ToArray();

            data.RemoveRange(startIndex, count);
            tempList = tempList.OrderBy(s => s).ToArray();
            data.InsertRange(startIndex, tempList);
        }

        private static void DataReverse(int startIndex, int count, List<string> data)
        {
            var tempList = data
                .Skip(startIndex)
                .Take(count)
                .ToArray();

            data.RemoveRange(startIndex, count);
            tempList = tempList.Reverse().ToArray();
            data.InsertRange(startIndex, tempList);
        }
    }
}