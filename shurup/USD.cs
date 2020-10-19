using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class USD : Values
    {
        private double kol;
        public double Kol
        {
            get
            {
                return Kol;
            }
            set
            {
                kol = value;
            }
        }
        public USD(double u_kol)
        {
            kol = u_kol * 80;
        }
        public override void Add(Values values)
        {
            kol += values.Get();
        }
        public override double Get()
        {
            return kol;
        }
        public override double GetInThisValue()
        {
            return kol / 80;
        }
    }
}
