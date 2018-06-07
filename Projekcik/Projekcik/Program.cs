using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
   public class Program
    {
        static void Main(string[] args)
        {
            Firma TestFunkcji = new Firma();
            /*
            Osoba osoba1 = new Osoba("PAwd", "dasd", TestFunkcji.PrzydzielanieID<Klient>(TestFunkcji.ListaKlientow,TestFunkcji.LNIDKlientow));
            TestFunkcji.ListaKlientow.Add(osoba1);


            Osoba osoba2 = new Osoba("PAaswd", "daasdsd", TestFunkcji.PrzydzielanieID<Klient>(TestFunkcji.ListaKlientow, TestFunkcji.LNIDKlientow));
            TestFunkcji.ListaKlientow.Add(osoba2);

            Lotnisko lotnisko1 = new Lotnisko("Nowyjork");
            Lotnisko Lotnisko2 = new Lotnisko("Berlon");
            TestFunkcji.ListaLotnisk.Add(lotnisko1);
            TestFunkcji.ListaLotnisk.Add(Lotnisko2);
            Trasa trasa = new Trasa(lotnisko1,Lotnisko2,230);
            // trasy - działa
            TestFunkcji.ListaTras.Add(trasa);
            Lot nowylot1 = new Lot(TestFunkcji.PrzydzielanieID<Lot>(TestFunkcji.ListaLotow, TestFunkcji.LNIDLotow),trasa,2000,9,21,8,3,false);
            TestFunkcji.ListaLotow.Add(nowylot1);
            Lot nowylot2 = new Lot(TestFunkcji.PrzydzielanieID<Lot>(TestFunkcji.ListaLotow, TestFunkcji.LNIDLotow), trasa, 2030, 9, 21, 8, 3,false);
            TestFunkcji.ListaLotow.Add(nowylot2);
            // loty - działa

            TypSamolotu nowytyp = new TypSamolotu("Test", 23, 23, 23, 12);
            nowytyp.DodajSamolot(TestFunkcji.PrzydzielanieID<Samolot>(nowytyp.GetListaSamolotow(), nowytyp.GetLNIDSamolotow()));
            nowytyp.DodajSamolot(TestFunkcji.PrzydzielanieID<Samolot>(nowytyp.GetListaSamolotow(), nowytyp.GetLNIDSamolotow()));// tą jedna linijką tworzy sie nowy samolot, dodaje do listy, i ma indywidualne id
           
    

           TestFunkcji.ZapisDoPliku();
         */
            TestFunkcji.OdczytZPliku();
            foreach (Trasa X in TestFunkcji.ListaTras)
                {
               Console.WriteLine(X.GetIDTrasy()+" ");
	            }
            

            Console.ReadLine();



        }
    }
}
