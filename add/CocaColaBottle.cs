using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class CocaColaBottle : Bottle
    {
        private Cola cola = null;
        private Label label = null;
        private Cap cap = null;
        public CocaColaBottle()
        {
            Console.WriteLine("Создана бутылка кока-колы");
        }
        public void PourCola(Cola c)
        {
            if (cap == null)
            {
                cola = c;
            }
            else
            {
                throw new BottleIsClosedException("Бутылка закрыта");
            }
        }
        public void StickLabel(Label l)
        {
            label = l;
        }
        public void CloseCap(Cap c)
        {
            cap = c;
        }
        public Bottle Copy()
        {
            Bottle bottle = new CocaColaBottle();
            bottle.CloseCap(cap.Copy());
            bottle.StickLabel(label.Copy());
            bottle.PourCola(cola.Copy());
            return bottle;
        }
    }
}
