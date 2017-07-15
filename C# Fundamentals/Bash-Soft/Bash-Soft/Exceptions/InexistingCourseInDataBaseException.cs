using System;

namespace Bash_Soft.Exceptions
{
    public class InexistingCourseInDataBaseException : Exception
    {
        private const string defaultMessage = "The course you are trying to get does not exist in the data base!";

        public InexistingCourseInDataBaseException(string message)
            : base(message)
        {
        }

        public InexistingCourseInDataBaseException()
            : base(defaultMessage)
        {
        }
    }
}