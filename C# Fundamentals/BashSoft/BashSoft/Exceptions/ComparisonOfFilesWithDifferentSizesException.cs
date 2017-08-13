using System;

namespace BashSoft.Exceptions
{
    public class ComparisonOfFilesWithDifferentSizesException : Exception
    {
        private const string defaultMessage = "Files not of equal size, certain mismatch.";

        public ComparisonOfFilesWithDifferentSizesException(string message)
            : base(message)
        {
        }

        public ComparisonOfFilesWithDifferentSizesException()
            : base(defaultMessage)
        {
        }
    }
}