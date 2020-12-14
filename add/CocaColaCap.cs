using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class CocaColaCap : Cap
    {
        public CocaColaCap()
        {
            Console.WriteLine("Закручена крышка кока-кола");
        }
        public Cap Copy()
        {
            return new CocaColaCap();
        }
    }
}
