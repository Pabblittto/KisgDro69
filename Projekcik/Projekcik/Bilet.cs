using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    public class Bilet : Rezerwacja
    {
        /// <summary>
        /// ten konstruktor będzie jest nie używany, bilet to klasa, na którą bedzie się rzutować rezerwacje- 
        /// jak koncepcja projektu się nie zmieni
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        public Bilet(string a, int b, int c,Boolean d,Klient e ):base(a,b,c,d,e )
        {

        }



        private string NrBiletu;
        
        /// <summary>
        /// Setter do numeru biletu,, będzie troche działał jak Konstruktor  
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
