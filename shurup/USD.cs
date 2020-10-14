using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class USD : Values
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
        public USD(int u_kol)
        {
            kol = u_kol;
        }
        public override int ToEur()
        {
            return kol * 8 / 9;
        }
        public override int ToUsd()
        {
            return kol;
        }
        public override int ToRub()
        {
            return kol * 80;
        }
    }
}
