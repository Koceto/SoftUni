using System;

namespace Bash_Soft.Exceptions
{
    public class InvalidStudentFilterException : Exception
    {
        private const string defaultMessage = "The given filter is not one of the following: excellent/average/poor";

        public InvalidStudentFilterException(string message)
            : base(message)
        {
        }

        public InvalidStudentFilterException()
            : base(defaultMessage)
        {
        }
    }
}