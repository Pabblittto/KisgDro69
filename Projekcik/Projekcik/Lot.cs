using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    public class Lot
    {
        private string IDLotu;

        // private List<Rezerwacja> ListaRezerwacji; // jeszcze nie wiem jak ta lista ma działać
        private String IDSamolotu;// id konkretnego zamolotu, który obsługuje lot 

        private Trasa Droga;
        private TypSamolotu Pojazd;// typ samolotu, ponieważ on przechowuje prekość, ładowność itd.
        private int CzasLotu;
        private string GodzinaWylotu;
        private string DataWylotu;


        public Lot(string ID, Trasa _Droga,string Wylot,string Data)
        {
            IDLotu = ID;
            Droga = _Droga;
            GodzinaWylotu = Wylot;
            DataWylotu = Data;

        }



        public string GetIDLotu()
        {
            return IDLotu;
        }
           public Trasa GetDroga()
        {
            return Droga;
        }
           public string GetGodzina()
        {
            return GodzinaWylotu;
        }
           public string GetData()
        {
            return DataWylotu;
        }





    }
}
