using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    public static class StartUp
    {
        public static void Main()
        {
            var commands = Console.ReadLine().Split(' ');
            var addToStack = int.Parse(commands[0]);
            var popStack = int.Parse(commands[1]);
            var checkIfContains = int.Parse(commands[2]);
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < addToStack; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < popStack; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(checkIfContains))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine('0');
                    return;
                }
                var smallest = int.MaxValue;

                foreach (int number in stack)
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