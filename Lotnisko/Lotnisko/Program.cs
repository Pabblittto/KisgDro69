using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    class Program
    {
        static void Main(string[] args)
        {

            Firma Lot = new Firma();

            Lot.DodajTyp("Boeing", 101, 102, 103, 104);
            Lot.DodajTyp("Airbus", 101, 102, 103, 104);

            Lot.ListaTypow[0].DodajSamolot();
            Lot.ListaTypow[0].DodajSamolot();
            Lot.ListaTypow[0].DodajSamolot();
            Lot.ListaTypow[1].DodajSamolot();
            Lot.ListaTypow[1].DodajSamolot();
            Lot.ListaTypow[1].DodajSamolot();

            Console.WriteLine("");

            Lot.PrzegladTypow();
            Lot.PrzegladSamolotow();

            Console.WriteLine("");

            Lot.UsunTyp("Airbus");
            Lot.PrzegladTypow();
            Lot.PrzegladSamolotow();

            Console.WriteLine("");

            Lot.DodajLotnisko("Warszawa");
            Lot.DodajLotnisko("Krakow");
            Lot.DodajTrase(Lot.ListaLotnisk[0], Lot.ListaLotnisk[1], 100);
            Lot.DodajTrase(Lot.ListaLotnisk[0], Lot.ListaLotnisk[1], 100);

            Lot.PrzegladLotnisk();
            Lot.PrzegladTras();

            Console.WriteLine("");

            Lot.DodajKlienta(Lot.StworzOsobe("Jacek", "Nicewiczowski"));
            Lot.DodajKlienta(Lot.StworzOsobe("Pawel", "Laska"));
            Lot.DodajKlienta(Lot.StworzPosrednika("Cos"));
            Lot.DodajKlienta(Lot.StworzPosrednika("druga"));

            Lot.PrzegladKlientow();

            Console.WriteLine();

            Console.WriteLine("Nacisnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}
