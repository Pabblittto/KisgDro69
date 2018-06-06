using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    public class Posrednik : Klient
    {
        private string Nazwa;

        /// <summary> Konstruktor pośrednika </summary>
        public Posrednik(string nazwa, string ID) : base(ID)
        {
            this.Nazwa = nazwa;
        }
        /// <summary> Zwraca nazwę pośrednika </summary>
        public string GetNazwa()
        {
            return Nazwa;
        }
    }
}