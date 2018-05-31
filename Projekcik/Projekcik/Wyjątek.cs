using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    /// <summary>
    /// wyjątek do programu, myśle że jeden wystarczy do wielu rzeczy- jak się umiejętnie korzysta
    /// </summary>
    class Wyjątek : Exception
    {
        public string Wiadomosc;

        public Wyjątek(string co_sie_stao)
        {
            Wiadomosc = co_sie_stao;
        }

        public override String ToString()
        {
            return Wiadomosc;
        }

    }
}
