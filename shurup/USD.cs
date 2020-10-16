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
            kol = u_kol;
        }

        public override double ToRub()
        {
            return kol * 80;
        }

        public override void Add(double smt)
        {
            kol += smt / 80;
        }
        public override double Get()
        {
            return kol;
        }
    }
}
