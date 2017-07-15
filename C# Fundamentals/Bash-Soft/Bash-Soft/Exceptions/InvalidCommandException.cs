using System;

namespace Bash_Soft.Exceptions
{
    public class InvalidCommandException : Exception
    {
        private const string defaultMessage = "Invalid command parameters!";

        public InvalidCommandException()
            : base(defaultMessage)
        {
        }

        public InvalidCommandException(string input)
            : base($"The command '{input}' is invalid")
        {
        }
    }
}