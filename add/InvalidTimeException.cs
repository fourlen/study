using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class InvalidTimeException : Exception
    {
        private int Time { get; set; }
        public InvalidTimeException(string message) :
            base(message)
        {
        }
    }
}