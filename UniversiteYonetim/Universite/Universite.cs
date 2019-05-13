using System;
using System.Collections.Generic;
using System.Text;

namespace UniversiteYonetim
{
    class Universite
    {
        private string isim { get; set; }

        public Universite(string isim)
        {
            this.isim = isim;
        }

        public string GetName()
        {
            return isim;
        }

        public void ChangeName(string isim)
        {
            this.isim = isim;
        }
    }
}
