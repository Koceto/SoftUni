using System;

namespace BashSoft.Exceptions
{
    public class InvalidScoreException : Exception
    {
        private const string defaultMessage = "Scores must be between 0 and 100";

        public InvalidScoreException(string message)
            : base(message)
        {
        }

        public InvalidScoreException()
            : base(defaultMessage)
        {
        }
    }
}