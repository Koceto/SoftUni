﻿using System.Collections.Generic;
using System.Linq;

namespace Reverse_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>(input);

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{stack.Pop()} ");
            }
        }
    }
}
