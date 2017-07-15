using System;

namespace Bash_Soft.Exceptions
{
    public class UnableToParseNumberException : Exception
    {
        private const string defaultMessage = "The sequence you've written is not a valid number.";

        public UnableToParseNumberException(string message)
            : base(message)
        {
        }

        public UnableToParseNumberException()
            : base(defaultMessage)
        {
        }
    }
}