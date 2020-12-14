using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    interface Bottle
    {
        public void PourCola(Cola cola);
        public void StickLabel(Label label);
        public void CloseCap(Cap cap);
        public Bottle Copy();
    }
}
