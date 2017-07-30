using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        private static void Main()
        {
            CustomStack<int> stack = new CustomStack<int>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] commandArgs = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string command = commandArgs[0];

                switch (command)
                {
                    case "Push":
                        stack.Push(commandArgs.Skip(1).Select(int.Parse).ToArray());
                        break;

                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;
                }
            }

            stack.PrintAll();
            stack.PrintAll();
        }
    }
}