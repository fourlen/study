using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class CocaColaFactory : ColaFactory
    {
        public Cola newCola()
        {
            return new CocaCola();
        }
        public Label newLabel()
        {
            return new CocaColaLabel();
        }
        public Cap newCap()
        {
            return new CocaColaCap();
        }
        public Bottle newBottle()
        {
            return new CocaColaBottle();
        }
    }
}
