using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    abstract class Values
    {
        public abstract void Add(Values values);
        public abstract double Get();
        public abstract double GetInThisValue();
    }
}
