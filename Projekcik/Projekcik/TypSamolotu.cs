﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    class TypSamolotu
    {
        public String NazwaModelu;

        public int Zasieg;
        public int Predkosc;
        public int IloscMiejsc;
        public int IloscMiejscVIP;

        List<Samolot> ListaSamolotow;

        public TypSamolotu(String Nazwa,int _Zasieg, int _Predkosc, int IlMiejsc, int IlMiejscVip)
        {
            NazwaModelu = Nazwa;
            Zasieg = _Zasieg;
            Predkosc = _Predkosc;
            IloscMiejsc = IlMiejsc;
            IloscMiejscVIP = IlMiejscVip;
            ListaSamolotow = new List<Samolot>();
        }

        public String GetNazwaModelu()
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

        public List<Samolot> GetListaSamolotow()
        {
            return ListaSamolotow;
        }

        /// <summary>
        /// Funkcja dodajaca sammolot zwraca false jeżeli samolot z takim samym id znajduje sie na liście 
        /// w przeciwnym wypadku zwraca true
        /// </summary>
        /// <param name="Dodawany"></param>
        /// <returns></returns>
        public Boolean DodajSamolot(Samolot Dodawany)
        {
            if (ListaSamolotow.Count() != 0)
            {
                foreach (Samolot Obiekt in ListaSamolotow)
                {
                    if (Obiekt.GetIDSamolotu() == Dodawany.GetIDSamolotu())
                        return false;
                }
            }

            ListaSamolotow.Add(Dodawany);
            return true;
        }

        /// <summary>
        /// Funkcja usuwa z listy samoolot który ma dane id
        /// </summary>
        /// <param name="IDSamolotu"></param>
        /// <returns></returns>
        public Boolean UsunSamolot(String IDSamolotu)
        {
            if (ListaSamolotow.Count() != 0)
            {
                for (int i = 0; i < ListaSamolotow.Count(); i++)
                {
                    if (ListaSamolotow[i].GetIDSamolotu() == IDSamolotu)
                    {
                        ListaSamolotow.Remove(ListaSamolotow[i]);
                        return true;
                    }
                }
            }
            return false;
        }


    }
}