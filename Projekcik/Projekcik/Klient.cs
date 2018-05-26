using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    public abstract class Klient
    {
        private string IDKlienta;

        public Klient(string ID)
            {
            IDKlienta=ID;
            }
        public GetIDKlienta()
            {
            return IDKlienta;
            }


    }
}
