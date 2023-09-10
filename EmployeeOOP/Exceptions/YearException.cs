﻿using System.Runtime.Serialization;

namespace EmployeeOOP.Exceptions
{
    [Serializable]
    internal class YearException : Exception
    {
        public YearException()
        {
        }

        public YearException(string? message) : base(message)
        {
        }

        public YearException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected YearException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}