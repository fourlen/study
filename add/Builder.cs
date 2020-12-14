using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class Builder
    {
        public Bottle _botttle;
        public Builder(ColaFactory _cf)
        {
            _botttle = _cf.newBottle();
            _botttle.PourCola(_cf.newCola());
            _botttle.StickLabel(_cf.newLabel());
            _botttle.CloseCap(_cf.newCap());
        }
        public Bottle Build()
        {
            return _botttle.Copy();
        }
    }
}
