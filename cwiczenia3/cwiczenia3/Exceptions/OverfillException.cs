using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia3.Exceptions
{
    public class OverfillException : Exception
    {

        public OverfillException()
        {
        }

        public OverfillException(string message) : base(message)
        {
        }

        public OverfillException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
