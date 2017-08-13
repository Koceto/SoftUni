using BashSoft.Contracts;
using System;

namespace BashSoft
{
    public class InputReader : IReader
    {
        private const string endCommand = "quit";
        private IInterpreter interpreter;

        public InputReader(IInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        public void StartReadingCommands()
        {
            OutputWriter.WriteMessage("Would you like to read the database automatically?");
            OutputWriter.WriteMessage("[y/n]>");
            string answer = Console.ReadLine().ToLower();

            if (answer[0] == 'y')
            {
                this.interpreter.InterpredCommand("cdRel ..");
                this.interpreter.InterpredCommand("cdRel ..");
                this.interpreter.InterpredCommand("readDb data.txt");
            }

            OutputWriter.WriteMessage("Don't forget you could use \"help\" to display all the commands.");
            OutputWriter.WriteEmptyLine();

            while (true)
            {
                OutputWriter.WriteMessage($"{SessionData.currentPath}>");
                string input = Console.ReadLine().Trim();

                if (input == endCommand)
                {
                    return;
                }

                this.interpreter.InterpredCommand(input);
            }
        }
    }
}