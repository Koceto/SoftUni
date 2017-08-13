using System;

namespace BashSoft.Exceptions
{
    public class UnauthorizedAccessException : Exception
    {
        private const string defaultMessage = "The folder/file you are trying to get access needs a higher level of rights than you currently have.";

        public UnauthorizedAccessException(string message)
            : base(message)
        {
        }

        public UnauthorizedAccessException()
            : base(defaultMessage)
        {
        }
    }
}