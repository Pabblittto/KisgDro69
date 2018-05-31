using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    /// <summary>
    /// Trasa to obiekt przechowyjący dwa lotniska, jest to po prostu droga
    /// </summary>
    public class Trasa
    {
        private Lotnisko Lotnisko1;
        private Lotnisko Lotnisko2;

        private int Odleglosc;

        private string IDTrasy;
        
        public Trasa(Lotnisko Lot1, Lotnisko Lot2, int odleg)
        {
            IDTrasy = Lotnisko1.GetIDLotniska()+'-'+Lotnisko2.GetIDLotniska();
            Lotnisko1 = Lot1;
            Lotnisko2 = Lot2;
            Odleglosc = odleg;
        }


        public int GetOdleglosc()
        {
            return Odleglosc;
        }

        public string GetIDTrasy()
        {
            return IDTrasy;
        }

        


    }
}
