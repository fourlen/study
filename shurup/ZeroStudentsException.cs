using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class ZeroStudentsException : Exception
    {
        public ZeroStudentsException(string message) : 
            base (message)
        { }
    }
}
