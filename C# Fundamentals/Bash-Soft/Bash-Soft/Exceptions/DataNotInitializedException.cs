using System;

namespace Bash_Soft.Exceptions
{
    public class DataNotInitializedException : Exception
    {
        private const string defaultMessage = "The data structure must be initialised first in order to make any operations with it.";

        public DataNotInitializedException(string message)
            : base(message)
        {
        }

        public DataNotInitializedException()
            : base(defaultMessage)
        {
        }
    }
}