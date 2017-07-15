﻿using Bash_Soft.Exceptions;

namespace Bash_Soft.IO.Commands
{
    public class PrintOrderedStudentsCommand : Command
    {
        public PrintOrderedStudentsCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager ioManager) : base(input, data, judge, repository, ioManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 5)
            {
                throw new InvalidCommandException(this.Input);
            }

            string courseName = this.Data[1];
            string filter = this.Data[2].ToLower();
            string takeCommand = this.Data[3].ToLower();
            string takeQuantity = this.Data[4].ToLower();

            TryParseParametersForOrderAndTake(takeCommand, takeQuantity, courseName, filter);
        }

        private void TryParseParametersForOrderAndTake(string takeCommand, string takeQuantity, string courseName, string filter)
        {
            if (takeCommand == "take")
            {
                if (takeQuantity == "all")
                {
                    this.Repository.OrderAndTake(courseName, filter);
                }
                else
                {
                    int studentstotake;
                    bool hasparsed = int.TryParse(takeQuantity, out studentstotake);

                    if (hasparsed)
                    {
                        this.Repository.OrderAndTake(courseName, filter, studentstotake);
                    }
                    else
                    {
                        throw new InvalidTakeQuantityParameterException();
                    }
                }
            }
            else
            {
                throw new InvalidTakeCommandException();
            }
        }
    }
}