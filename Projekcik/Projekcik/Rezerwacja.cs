using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    class Rezerwacja
    {
        private Klient Pasazer;

        private String NrRezerwacji;
        private int NrMiesca;
        private int CenaBiletu;
        private Boolean BiletVIP;

        public Rezerwacja(String NrRezer,int NumerMiejs,int _Cena,Boolean Vip, Klient KtoRezerw)
        {
            Pasazer = KtoRezerw;
            NrRezerwacji = NrRezer;
            NrMiesca = NumerMiejs;
            CenaBiletu = _Cena;
            BiletVIP = Vip;
        }


        public String GetNrRezerwacji()
        {
            return NrRezerwacji;
        }




    }
}
