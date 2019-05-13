using System;
using System.Collections.Generic;
using System.Text;

namespace UniversiteYonetim
{
    class Girdi
    {
        public static char GirdiKarakter()
        {
            char girdi;
            try
            {
                girdi = Convert.ToChar(Console.ReadLine());
            }
            catch (FormatException)
            {
                girdi = '0';
            }
            return girdi;
        }
    }
}
