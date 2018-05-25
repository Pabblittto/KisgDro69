using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    class Bilet : Rezerwacja
    {
        // ma konstruktora po prostu


        private String NrBiletu;
        
        /// <summary>
        /// Setter do numeru biletu,, będzie troche działał jak Konstruktor
        /// </summary>
        /// <param name="numer"></param>
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
