using System;

namespace Bash_Soft.Exceptions
{
    public class InvalidPathException : Exception
    {
        private const string InvalidPath = "The folder/file you are trying to access at the current address, does not exist.";

        public InvalidPathException(string message)
            : base(message)
        {
        }

        public InvalidPathException()
            : base(InvalidPath)
        {
        }
    }
}