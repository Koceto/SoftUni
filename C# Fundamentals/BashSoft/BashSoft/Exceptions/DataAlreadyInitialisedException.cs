using System;

namespace BashSoft.Exceptions
{
    public class DataAlreadyInitialisedException : Exception
    {
        private const string defaultMessage = "Data is already initialized!";

        public DataAlreadyInitialisedException(string message)
            : base(message)
        {
        }

        public DataAlreadyInitialisedException()
            : base(defaultMessage)
        {
        }
    }
}