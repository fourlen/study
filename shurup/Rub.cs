using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class Rub : Values
    {
        private int kol;
        public int Kol
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
        public Rub(int r_kol)
        {
            kol = r_kol;
        }
        public override int ToEur()
        {
            return kol / 90;
        }
        public override int ToUsd()
        {
            return kol / 80;
        }
        public override int ToRub()
        {
            return kol;
        }
    }
}
