using System;
using System.Collections.Generic;

namespace Balanced_Parenthesis
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentSymbol = input[i];

                if (currentSymbol == '{' || currentSymbol == '[' || currentSymbol == '(')
                {
                    stack.Push(currentSymbol);
                }
                else
                {
                    var lastSymbol = default(char);

                    if (stack.Count <= 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    switch (stack.Peek())
                    {
                        case '{':
                            lastSymbol = '}';
                            break;
                        case '(':
                            lastSymbol = ')';
                            break;
                        case '[':
                            lastSymbol = ']';
                            break;
                    }

                    if (currentSymbol == lastSymbol)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
