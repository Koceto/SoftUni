using System;

namespace Bash_Soft.Exceptions
{
    public class InvalidTakeCommandException : Exception
    {
        private const string defaultMessage = "The take command expected does not match the format wanted!";

        public InvalidTakeCommandException(string message)
            : base(message)
        {
        }

        public InvalidTakeCommandException()
            : base(defaultMessage)
        {
        }
    }
}