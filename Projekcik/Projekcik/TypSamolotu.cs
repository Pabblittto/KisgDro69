using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
     public class TypSamolotu
    {
        public string NazwaModelu;

        public int Zasieg;
        public int Predkosc;
        public int IloscMiejsc;
        public int IloscMiejscVIP;

        private LinkedList<Samolot> ListaSamolotow; //zmiana typu listy na linked bo jest szybsza w przegladaniu

        public TypSamolotu(string Nazwa,int _Zasieg, int _Predkosc, int IlMiejsc, int IlMiejscVip)
        {
            NazwaModelu = Nazwa;
            Zasieg = _Zasieg;
            Predkosc = _Predkosc;
            IloscMiejsc = IlMiejsc;
            IloscMiejscVIP = IlMiejscVip;
            ListaSamolotow = new LinkedList<Samolot>();
        }

        public string GetNazwaModelu()
        {
            return NazwaModelu;
        }

        public int GetIloscMiejsc()
        {
            return IloscMiejsc;
        }

        public int GetPredkosc()
        {
            return Predkosc;
        }

        public int GetIloscMiejscVip()
        {
            return IloscMiejscVIP;
        }

        public int GetZasieg()
        {
            return Zasieg;
        }
        public LinkedList<Samolot> GetListaSamolotow()
        {
            return ListaSamolotow;
        }

        /// <summary>
        /// Funkcja dodajaca sammolot zwraca false jeżeli samolot z takim samym id znajduje sie na liście 
        /// w przeciwnym wypadku zwraca true
        /// </summary>
        /// <param name="Dodawany"></param>
        /// <returns></returns>
        public Boolean DodajSamolot(string IDSamolotu)
        {
            if (ListaSamolotow.Count() != 0)
            {
                foreach (Samolot Obiekt in ListaSamolotow)
                {
                    if (Obiekt.GetIDSamolotu() == IDSamolotu)
                        return false;
                }
            }
            //mala zmiana - lepiej jak w nizsszej metodzie sprawdzac tylko ID bo nowy samolot i tak bedzie mial takie same parametry a roznil sie tylko ID
            ListaSamolotow.Add(new Samolot(IDSamolotu));
            return true;
        }

        /// <summary>
        /// Funkcja usuwa z listy samoolot który ma dane id
        /// </summary>
        /// <param name="IDSamolotu"></param>
        /// <returns></returns>
        public Boolean UsunSamolot(string IDSamolotu)
        {
            if (ListaSamolotow.Count() != 0)
            {
                for (int i = 0; i < ListaSamolotow.Count(); i++)
                {
                    if (ListaSamolotow[i].GetIDSamolotu() == IDSamolotu)
                    {
                        ListaSamolotow.Remove(i);
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
