using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    public class Osoba : Klient
    {
        private string Imie;
        private string Nazwisko;

        /// <summary> Konstruktor osoby </summary>
        public Osoba(string _Imie, string _Nazwisko, string ID) : base(ID)
        {

            this.Imie = _Imie;
            this.Nazwisko = _Nazwisko;
        }

        /// <summary> Zwraca Imię </summary>
        public string GetImie()
        {
            return Imie;
        }
        /// <summary> Zwraca nazwisko </summary>
        public string GetNazwisko()
        {
            return Nazwisko;
        }

    }
}
