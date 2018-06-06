using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    [Serializable]
    public class TypSamolotu
    {
        private string NazwaModelu;
        private int Zasieg;             // podawana w km
        private int Predkosc;           // prędkośc podawana w km/h
        private int IloscMiejsc;        // ilość miejsc zwykłych
        private int IloscMiejscVIP;     // ilość miejsc VIP

        private int Stworzonych;
        private List<Samolot> ListaSamolotow;

        /// <summary>
        /// Konstruktor typu samolotu.
        /// Wykorzystuje Nazwę, Zasięg, Prędkość, Ilość miejsc, Ilość miejsc VIP
        /// </summary>
        public TypSamolotu(string _NazwaModelu, int _Zasieg, int _Predkosc, int _IloscMiejsc, int _IloscMiejscVIP)
        {
            NazwaModelu = _NazwaModelu;
            Zasieg = _Zasieg;
            Predkosc = _Predkosc;
            IloscMiejsc = _IloscMiejsc;
            IloscMiejscVIP = _IloscMiejscVIP;
            Stworzonych = 0;
            ListaSamolotow = new List<Samolot>();
        }

        /// <summary> Zwraca nazwę modelu </summary>
        public string GetNazwaModelu()
        {
            return NazwaModelu;
        }
        /// <summary> Zwraca zasięg </summary>
        public int GetZasieg()
        {
            return Zasieg;
        }
        /// <summary> Zwraca prędkość </summary>
        public int GetPredkosc()
        {
            return Predkosc;
        }
        /// <summary> Zwraca ilość miejsc </summary>
        public int GetIloscMiejsc()
        {
            return IloscMiejsc;
        }
        /// <summary> Zwraca ilość miejsc VIP </summary>
        public int GetIloscMiejscVIP()
        {
            return IloscMiejscVIP;
        }
        /// <summary> Zwraca ilość stworzonych samolotów danego typu </summary>
        public int GetStworzonych()
        {
            return Stworzonych;
        }
        /// <summary> Zwraca listę samolotów danego typu </summary>
        public List<Samolot> GetListaSamolotow()
        {
            return ListaSamolotow;
        }

        /// <summary>
        /// Funkcja dodajaca nowy samolot danego typu
        /// </summary>
        /// <returns></returns>
        public Boolean DodajSamolot()
        {
            Stworzonych++;
            string IDSamolotu = NazwaModelu + "-" + Stworzonych.ToString().PadLeft(5, '0');
            ListaSamolotow.Add(new Samolot(IDSamolotu));
            return true;
        }

        /// <summary>
        /// Funkcja usuwa z listy samoolot który ma dane ID
        /// Jeżeli dany samolot istnieje na liście zwraca true, w przeciwnym wypadku zwraca false
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
                        ListaSamolotow.Remove(ListaSamolotow[i]);
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Funkcja zwraca obiekt Samolotu o podanym ID.
        /// Funkcja może się przydac żeby sprawdzić czy dany samolot jest wolny.
        /// Zwraca nulla jeżeli tego id nie ma na liście .
        /// </summary>
        /// <param name="IDszukanegoSamolotu"></param>
        /// <returns></returns>
        public Samolot GetSamolotOID(string IDszukanegoSamolotu)
        {
            foreach (Samolot Obiekt in ListaSamolotow)
            {
                if (Obiekt.GetIDSamolotu() == IDszukanegoSamolotu)
                    return Obiekt;
            }
            throw new Wyjatek("Nie ma takiego Samolotu o podanym ID na liście!! ");// niech użytkownik wpisze te ID jeszcze raz, jeżeli ma możliwość wgl
        }
    }
}
