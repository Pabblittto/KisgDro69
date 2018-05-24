using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    class Trasa
    {
        private Lotnisko Lotnisko1;
        private Lotnisko Lotnisko2;

        private int Odleglosc;

        private String IDTrasy;

        public Trasa(String ID, Lotnisko Lot1, Lotnisko Lot2, int odleg)
        {
            IDTrasy = ID;
            Lotnisko1 = Lot1;
            Lotnisko2 = Lot2;
            Odleglosc = odleg;
        }


        public int GetOdleglosc()
        {
            return Odleglosc;
        }

        public String GetIDTrasy()
        {
            return (Lotnisko1.GetIDLotniska() + "-" + Lotnisko2.GetIDLotniska());
        }

        


    }
}
