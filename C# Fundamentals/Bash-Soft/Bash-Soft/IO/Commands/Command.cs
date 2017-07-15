using System;
using Bash_Soft.Exceptions;

namespace Bash_Soft.IO.Commands
{
    public abstract class Command
    {
        private string input;
        private string[] data;
        private Tester judge;
        private StudentsRepository repository;
        private IOManager ioManager;

        protected Command(string input, string[] data, Tester judge, StudentsRepository repository, IOManager ioManager)
        {
            this.Input = input;
            this.Data = data;
            this.judge = judge;
            this.repository = repository;
            this.ioManager = ioManager;
        }

        protected IOManager IOManager
        {
            get { return this.ioManager; }
        }

        protected StudentsRepository Repository
        {
            get { return this.repository; }
        }

        protected Tester Judge
        {
            get { return this.judge; }
        }

        protected string[] Data
        {
            get { return this.data; }
            private set
            {
                if (value == null || value.Length == 0)
                {
                    throw new NullReferenceException();
                }
                this.data = value;
            }
        }

        protected string Input
        {
            get { return this.input; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }
                this.input = value;
            }
        }

        public abstract void Execute();
    }
}