using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class USD : Values
    {
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
        public override double GetInRub()
        {
            return kol;
        }
        public override double Get()
        {
            return kol / 80;
        }
    }
}
