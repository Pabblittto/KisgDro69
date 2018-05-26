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

        // private List<Rezerwacja> ListaRezerwacji;

        private Trasa Droga;

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




    }
}
