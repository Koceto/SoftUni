using ListyIterator.Generics;
using System;
using System.Linq;

namespace ListyIterator.Core
{
    public class Engine
    {
        private ListyIterator<string> listyIterator;

        public Engine()
        {
            this.listyIterator = new ListyIterator<string>();
        }

        public void Run()
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] commandArgs = input.Split(' ');

                CommandInterpreter(commandArgs);
            }
        }

        private void CommandInterpreter(string[] commandArgs)
        {
            string command = commandArgs[0];

            switch (command)
            {
                case "Create":
                    try
                    {
                        listyIterator.Create(commandArgs.Skip(1));
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                    break;

                case "Move":
                    Console.WriteLine(listyIterator.Move());
                    break;

                case "Print":
                    listyIterator.Print();
                    break;

                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext());
                    break;
                case "PrintAll":
                    this.listyIterator.PrintAll();
                    break;
            }
        }
    }
}