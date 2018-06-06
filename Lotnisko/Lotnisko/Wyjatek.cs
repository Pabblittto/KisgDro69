using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    /// <summary>
    /// wyjątek do programu jeden wystarczy do wielu rzeczy- jak się umiejętnie korzysta
    /// </summary>
    class Wyjatek : Exception
    {
        public string Wiadomosc;

        /// <summary> Konstruktor nowego wyjątku </summary>
        public Wyjatek(string co_sie_stalo)
        {
            Wiadomosc = co_sie_stalo;
        }
        /// <summary> Zwraca wiadomość wyjątku </summary>
        public override String ToString()
        {
            return Wiadomosc;
        }

    }
}