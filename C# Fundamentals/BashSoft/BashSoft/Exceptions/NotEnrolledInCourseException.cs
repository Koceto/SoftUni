using System;

namespace BashSoft.Exceptions
{
    public class NotEnrolledInCourseException : Exception
    {
        private const string defaultMessage = "Student must be enrolled in a course before you set his mark.";

        public NotEnrolledInCourseException(string message)
            : base(message)
        {
        }

        public NotEnrolledInCourseException()
            : base(defaultMessage)
        {
        }
    }
}