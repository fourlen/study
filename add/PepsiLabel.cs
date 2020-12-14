using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class PepsiLabel : Label
    {
        public PepsiLabel()
        {
            Console.WriteLine("Наклеена этикетка пепси");
        }
        public Label Copy()
        {
            return new PepsiLabel();
        }
    }
}
