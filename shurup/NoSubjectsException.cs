﻿using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class NoSubjectsException : Exception
    {
        public NoSubjectsException(string message) : 
            base(message)
        { }
    }
}
