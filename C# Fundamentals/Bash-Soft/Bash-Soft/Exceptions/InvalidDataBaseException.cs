using System;

namespace Bash_Soft.Exceptions
{
    public class InvalidDataBaseException : Exception
    {
        private const string defaultMessage = "Cannot find any courses in DataBase";

        public InvalidDataBaseException(string message)
            : base(message)
        {
        }

        public InvalidDataBaseException()
            : base(defaultMessage)
        {
        }
    }
}