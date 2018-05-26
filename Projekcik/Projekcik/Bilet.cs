using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    public class Bilet : Rezerwacja
    {
        //  nie ma konstruktora po prostu


        private string NrBiletu;
        
        /// <summary>
        /// Setter do numeru biletu,, będzie troche działał jak Konstruktor  ds
        /// </summary>
        /// <param name="numer"></param>
        public void SetNrBiletu(string numer)
        {
            NrBiletu = numer;
        }

        public string GetNrBiletu()
        {
            return NrBiletu;
        }
            
            
            
    }
}
