using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class CareTaker
    {
        private List<Memento> saves = new List<Memento>();
        public void Save(Memento save)
        {
            saves.Add(save);
        }
        public Memento Load(int i)
        {
            return saves[i];
        }
    }
}
