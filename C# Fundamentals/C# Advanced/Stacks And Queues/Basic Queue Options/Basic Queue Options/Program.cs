using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Basic_Stack_Operations
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var commands = Console.ReadLine().Split(' ');
            var addToStack = int.Parse(commands[0]);
            var popStack = int.Parse(commands[1]);
            var checkIfContains = int.Parse(commands[2]);
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            for (int i = 0; i < addToStack; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < popStack; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(checkIfContains))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine('0');
                    return;
                }

                var smallest = int.MaxValue;

                foreach (int number in queue)
                {
                    if (number < smallest)
                    {
                        smallest = number;
                    }
                }

                Console.WriteLine(smallest);
            }
        }
    }
}
