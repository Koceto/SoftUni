using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                var input = Console.ReadLine()
                    .ToLower()
                    .Split()
                    .ToArray();

                if (input[0] == "print")
                {
                    Console.WriteLine("[{0}]", string.Join(", ", numbers));
                    return;
                }
                else if (input[0] == "add")
                {
                    int index = int.Parse(input[1]);
                    int element = int.Parse(input[2]);

                    numbers.Insert(index, element);
                }
                else if (input[0] == "addmany")
                {
                    int index = int.Parse(input[1]);
                    var elements = new List<int>(input.Skip(2).Select(int.Parse));

                    numbers.InsertRange(index, elements);
                }
                else if (input[0] == "contains")
                {
                    int element = int.Parse(input[1]);
                    Console.WriteLine(numbers.FindIndex(n => n == element));
                }
                else if (input[0] == "remove")
                {
                    int index = int.Parse(input[1]);

                    numbers.RemoveAt(index);
                }
                else if (input[0] == "shift")
                {
                    int rotate = int.Parse(input[1]);

                    for (int i = 0; i < rotate; i++)
                    {
                        int first = numbers[0];

                        numbers.RemoveAt(0);
                        numbers.Add(first);
                    }
                }
                else if (input[0] == "sumpairs")
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        numbers[i] += numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                    }
                }
            }
        }
    }
}

