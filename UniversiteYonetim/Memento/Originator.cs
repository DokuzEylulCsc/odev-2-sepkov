using System;
using System.Collections.Generic;
using System.Text;

namespace UniversiteYonetim
{
    class Originator
    {
        private string state;

        public void setState(string state)
        {
            this.state = state;
        }

        public String getState()
        {
            return state;
        }

        public Memento saveStateToMemento()
        {
            return new Memento(state);
        }

        public void getStateFromMemento(Memento memento)
        {
            state = memento.getState();
        }
    }
}
