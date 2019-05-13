using System;
using System.Collections.Generic;
using System.Text;

namespace UniversiteYonetim
{
    class CareTaker
    {
        private List<Memento> mementos = new List<Memento>();

        public void add(Memento state)
        {
            mementos.Add(state);
        }

        public Memento get(int index)
        {
            return mementos[index];
        }
    }
}
