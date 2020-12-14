using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class PepsiBottle : Bottle
    {
        Cola cola = new Pepsi();
        Label label = new PepsiLabel();
        Cap cap = new PepsiCap();
        public PepsiBottle()
        {
            Console.WriteLine("Создана бутылка пепси");
        }
        public void PourCola(Cola c)
        {
            cola = c;
        }
        public void StickLabel(Label l)
        {
            label = l;
        }
        public void CloseCap(Cap c)
        {
            cap = c;
        }
    }
}
