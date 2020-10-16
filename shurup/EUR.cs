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
            kol = e_kol;
        }
        public override double ToRub()
        {
            return kol * 90;
        }
        public override void Add(double smt)
        {
            kol += smt / 90;
        }
        public override double Get()
        {
            return kol;
        }
    }
}
