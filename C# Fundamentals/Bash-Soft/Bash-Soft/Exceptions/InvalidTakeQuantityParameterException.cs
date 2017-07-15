using System;

namespace Bash_Soft.Exceptions
{
    public class InvalidTakeQuantityParameterException : Exception
    {
        private const string defaultMessage = "The ammount you selected is invalid";

        public InvalidTakeQuantityParameterException(string message)
            : base(message)
        {
        }

        public InvalidTakeQuantityParameterException()
            : base(defaultMessage)
        {
        }
    }
}