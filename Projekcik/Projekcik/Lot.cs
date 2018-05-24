using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    class Lot
    {
        private String IDLotu;

        // private List<Rezerwacja> ListaRezerwacji;

        private Trasa Droga;

        private int CasLotu;
        private String GodzinaWylotu;
        private String DataWylotu;


        public Lot(String ID, Trasa _Droga,String Wylot,String Data)
        {
            IDLotu = ID;
            Droga = _Droga;
            GodzinaWylotu = Wylot;
            DataWylotu = Data;
        }



        public String GetIDLotu()
        {
            return IDLotu;
        }




    }
}
