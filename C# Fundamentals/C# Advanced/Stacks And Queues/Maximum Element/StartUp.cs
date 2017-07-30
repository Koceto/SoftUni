using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    public static class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxValues = new Stack<int>();
            maxValues.Push(int.MinValue);

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                switch (input.First())
                {
                    case 1:
                        stack.Push(input.Last());

                        if (stack.Peek() > maxValues.Peek())
                        {
                            maxValues.Push(stack.Peek());
                        }
                        break;

                    case 2:

                        if (stack.Peek() == maxValues.Peek())
                        {
                            maxValues.Pop();
                        }

                        stack.Pop();
                        break;

                    default:
                        Console.WriteLine(maxValues.Peek());
                        break;
                }
            }
        }
    }
}