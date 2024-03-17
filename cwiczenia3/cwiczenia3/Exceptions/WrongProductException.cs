using System;
namespace cwiczenia3.Exceptions
{
    public class WrongProductException : Exception
    {

        public WrongProductException() { }
        public WrongProductException(string message) : base(message) { }
        public WrongProductException(string message, Exception innerException) : base(message, innerException) {}
    }
}
