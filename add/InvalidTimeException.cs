using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class InvalidTimeException : Exception
    {
        public InvalidTimeException(string message) :
            base(message)
        {
        }
    }
}