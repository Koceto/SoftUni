﻿using System;

namespace Bash_Soft.Exceptions
{
    public class UnableToGoHigherInPartitionHierarchyException : Exception
    {
        private const string defaultMessage = "Cannot go higher that root folder";

        public UnableToGoHigherInPartitionHierarchyException(string message)
            : base(message)
        {
        }

        public UnableToGoHigherInPartitionHierarchyException()
            : base(defaultMessage)
        {
        }
    }
}