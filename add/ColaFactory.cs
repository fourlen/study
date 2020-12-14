using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    interface ColaFactory
    {
        public Cola newCola();
        public Bottle newBottle();
        public Label newLabel();
        public Cap newCap();
    }
}
