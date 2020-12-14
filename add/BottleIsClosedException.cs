using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class BottleIsClosedException : Exception
    {
        public BottleIsClosedException(string message) :
            base (message)
        { }
    }
}
