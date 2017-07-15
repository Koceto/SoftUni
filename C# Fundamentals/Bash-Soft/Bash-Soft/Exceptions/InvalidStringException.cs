using System;

namespace Bash_Soft.Exceptions
{
    public class InvalidStringException : Exception
    {
        private const string NullOrEmptyValue = "The value of the variable CANNOT be null or empty!";

        public InvalidStringException(string message)
            : base(message)
        {
        }

        public InvalidStringException()
            : base(NullOrEmptyValue)
        {
        }
    }
}