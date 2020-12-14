using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class PepsiCap : Cap
    {
        public PepsiCap()
        {
            Console.WriteLine("Закурчена крышка пепси");
        }
        public Cap Copy()
        {
            return new PepsiCap();
        }
    }
}
