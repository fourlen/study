using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class EUR : Values
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
        public EUR (double e_kol)
        {
            kol = e_kol * 90;
        }
        public override double GetInRub()
        {
            return kol;
        }
        public override double Get()
        {
            return kol / 90;
        }
    }
}
