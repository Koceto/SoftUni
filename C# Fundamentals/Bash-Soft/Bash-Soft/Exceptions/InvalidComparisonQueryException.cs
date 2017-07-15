using System;

namespace Bash_Soft.Exceptions
{
    public class InvalidComparisonQueryException : Exception
    {
        private const string defaultMessage = "The comparison query you want, does not exist in the context of the current program!";

        public InvalidComparisonQueryException(string message)
            : base(message)
        {
        }

        public InvalidComparisonQueryException()
            : base(defaultMessage)
        {
        }
    }
}