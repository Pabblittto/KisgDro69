using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    class Bilet : Rezerwacja
    {
        private String NrBiletu;

        public void SetNrBiletu(String numer)
        {
            NrBiletu = numer;
        }

        public String GetNrBiletu()
        {
            return NrBiletu;
        }
            
            
            
    }
}
