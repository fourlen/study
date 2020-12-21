using System;
using System.Collections.Generic;
using System.Text;

namespace add
{
    class CareTaker
    {
        public List<Memento> saves { get; set; } = new List<Memento>();
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
