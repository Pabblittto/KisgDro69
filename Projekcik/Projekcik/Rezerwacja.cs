using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    [Serializable]
    public class Rezerwacja
    {
        private Klient Pasazer;

        private string NrRezerwacji;
        private int NrMiesca;
        private int CenaBiletu;
        private Boolean BiletVIP;

        public Rezerwacja(string NrRezer,int NumerMiejs,int _Cena,Boolean Vip, Klient KtoRezerw)
        {
            Pasazer = KtoRezerw;
            NrRezerwacji = NrRezer;
            NrMiesca = NumerMiejs;
            CenaBiletu = _Cena;
            BiletVIP = Vip;
        }


        public string GetNrRezerwacji()
        {
            return NrRezerwacji;
        }

        public Boolean CzyVIP()
        {
            return BiletVIP;
        }



    }
}
