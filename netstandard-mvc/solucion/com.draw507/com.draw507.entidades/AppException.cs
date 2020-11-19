using System;

namespace com.draw507.entidades
{
    public class AppException : Exception
    {
        public AppException()
            : base() { }

        public AppException(String message)
            : base(message) { }

        public AppException(String message, Exception innerException)
            : base(message, innerException) { }
    }
}
