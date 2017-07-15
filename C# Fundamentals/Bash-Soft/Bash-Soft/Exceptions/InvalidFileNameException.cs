using System;

namespace Bash_Soft.Exceptions
{
    public class InvalidFileNameException : Exception
    {
        private const string ForbiddenSymbolsContainedInName = "The given name contains symbols that are not allowed to be used in names of files and folders.";

        public InvalidFileNameException(string message)
            : base(message)
        {
        }

        public InvalidFileNameException()
            : base(ForbiddenSymbolsContainedInName)
        {
        }
    }
}