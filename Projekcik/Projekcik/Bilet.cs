using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    /// <summary>
    /// ta cała klasa będzie do usunięcia :/  serio mówie 
    /// </summary>
    public class Bilet : RezerwcjaBilet
    {

        public Bilet(string nrRezerwacji, int NumerMiejsca, int _cena,Boolean Vip,Klient KtoRezerwuje, DateTime Datastworzenia ,string _nrBiletu):base(nrRezerwacji,NumerMiejsca,_cena,Vip,KtoRezerwuje,Datastworzenia,true )
        {
            NrBiletu = _nrBiletu;
        }



        private string NrBiletu;
        
        /// <summary>
        /// Setter do numeru biletu potrzebny jeżeli rzutujemy w dół i pole nr biletu siędodaje 
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
