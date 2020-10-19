using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class EUR : Values
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
        public EUR (double e_kol)
        {
            kol = e_kol * 90;
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
            return kol / 90;
        }
    }
}
