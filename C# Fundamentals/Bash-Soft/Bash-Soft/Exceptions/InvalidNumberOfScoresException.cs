using System;

namespace Bash_Soft.Exceptions
{
    public class InvalidNumberOfScoresException : Exception
    {
        private const string defaultMessage = "The number of scores for the given course is greater than the possible.";

        public InvalidNumberOfScoresException(string message)
            : base(message)
        {
        }

        public InvalidNumberOfScoresException()
            : base(defaultMessage)
        {
        }
    }
}