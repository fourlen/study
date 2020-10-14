using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class EUR : Values
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
        public EUR(int e_kol)
        {
            kol = e_kol;
        }
        public override int ToEur()
        {
            return kol;
        }
        public override int ToUsd()
        {
            return kol * 9 / 8;
        }
        public override int ToRub()
        {
            return kol * 90;
        }
    }
}
