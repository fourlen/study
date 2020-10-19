using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    abstract class Values
    {
        protected double kol;
        public void Add(Values values)
        {
            kol += values.GetInRub();
        }
        public abstract double GetInRub();
        public abstract double Get();
    }
}
