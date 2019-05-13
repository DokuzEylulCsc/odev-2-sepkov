using System;
using System.Collections.Generic;
using System.Text;

namespace UniversiteYonetim
{
    class Memento
    {
        private string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public String getState()
        {
            return state;
        }
    }
}
