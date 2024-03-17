using System;
namespace cwiczenia3.Exceptions
{
    public class WrongTemperatureException : Exception
    {

        public WrongTemperatureException() { }
        public WrongTemperatureException(string message) : base(message) { }
        public WrongTemperatureException(string message, Exception innerException) : base(message, innerException) { }
    }
}
