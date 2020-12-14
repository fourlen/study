using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class CocaColaLabel : Label
    {
        public CocaColaLabel()
        {
            Console.WriteLine("Наклеена этикета кока-кола");
        }
        public Label Copy()
        {
            return new CocaColaLabel();
        }
    }
}
