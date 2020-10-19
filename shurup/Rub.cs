using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class Rub : Values
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
        public Rub(double r_kol)
        {
            kol = r_kol;
        }
        public double ToEur()
        {
            return kol / 90;
        }
        public double ToUsd()
        {
            return kol / 80;
        }
        public override double GetInRub()
        {
            return kol;
        }
        public override double Get()
        {
            return kol;
        }
    }
}
