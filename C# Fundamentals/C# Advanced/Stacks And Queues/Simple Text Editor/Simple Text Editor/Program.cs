using System.Collections.Generic;
using System.Linq;

namespace Simple_Text_Editor
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var myText = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().TrimStart().ToCharArray();
                var command = input.First();

                if (command == '1') // Add to String
                {
                    var stringToAdd = string.Join("", input.Skip(2));

                    if (myText.Count > 0)
                    {
                        myText.Push(String.Concat(myText.Peek(), stringToAdd));
                    }
                    else
                    {
                        myText.Push(stringToAdd);
                    }
                }
                else if (command == '2') // Erase last N chars
                {
                    var number = int.Parse(string.Join("", input.Skip(2)));
                    var lastText = myText.Peek();
                    var modifiedText = lastText.Substring(0, lastText.Length - number);

                    myText.Push(modifiedText);
                }
                else if (command == '3') // Print N-th char
                {
                    var number = int.Parse(string.Join("", input.Skip(2)));
                    var lastText = myText.Peek();
                    Console.WriteLine(lastText[number - 1]);
                }
                else // Undo
                {
                    myText.Pop();
                }
            }
        }
    }
}