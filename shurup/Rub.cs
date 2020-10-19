using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class Rub : Values
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
            return kol;
        }
    }
}
