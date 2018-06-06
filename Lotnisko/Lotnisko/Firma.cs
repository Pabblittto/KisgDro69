using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Projekcik
{
    class Firma
    {
        public List<Lotnisko> ListaLotnisk = new List<Lotnisko>();
        public List<Trasa> ListaTras = new List<Trasa>();
        public List<TypSamolotu> ListaTypow = new List<TypSamolotu>();
        public List<Klient> ListaKlientow = new List<Klient>();

        private int LiczbaOsob = 0;
        private int LiczbaPosrednikow = 0;

        private DateTime WirtualnaData;// będe tego później potrzebował, i w firmie bede pisał ewentualnie rózne funkcje odnośnie czasu~Pabblo







        /// <summary> Dodaje nowy typ samolotu </summary>
        public Boolean DodajTyp(string _NazwaModelu, int _Zasieg, int _Predkosc, int _IloscMiejsc, int _IloscMiejscVIP)
        {
            if (ListaTypow.Count() != 0)
            {
                foreach (TypSamolotu Obiekt in ListaTypow)
                {
                    if (Obiekt.GetNazwaModelu() == _NazwaModelu)
                        return false;
                }
            }

            ListaTypow.Add(new TypSamolotu(_NazwaModelu, _Zasieg, _Predkosc, _IloscMiejsc, _IloscMiejscVIP));
            return true;
        }
        /// <summary> Usuwa typ samolotu </summary>
        public Boolean UsunTyp(string NazwaTypu)
        {
            if (ListaTypow.Count() != 0)
            {
                for (int i = 0; i < ListaTypow.Count(); i++)
                {
                    if (ListaTypow[i].GetNazwaModelu() == NazwaTypu)
                    {
                        ListaTypow.Remove(ListaTypow[i]);
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary> Wystietla typy samolotow </summary>
        public void PrzegladTypow()
        {
            if (ListaTypow.Count() != 0)
            {
                for (int i = 0; i < ListaTypow.Count(); i++)
                {
                    Console.WriteLine("Nazwa modelu: " + ListaTypow[i].GetNazwaModelu());
                    Console.WriteLine("Stworzonych:  " + ListaTypow[i].GetStworzonych());
                }
            }
            else
            {
                Console.WriteLine("Brak typow samolotow do wyswietlenia");
            }
        }
        /// <summary> Wyswietla samoloty wszystkich typow </summary>
        public void PrzegladSamolotow()
        {
            if (ListaTypow.Count() != 0)
            {
                for (int i = 0; i < ListaTypow.Count(); i++)
                {
                    Console.WriteLine("Nazwa modelu: " + ListaTypow[i].GetNazwaModelu());
                    Console.WriteLine("Stworzonych:  " + ListaTypow[i].GetStworzonych());
                    for (int j = 0; j < ListaTypow[i].GetListaSamolotow().Count(); j++)
                    {
                        Console.WriteLine("Samolot: " + ListaTypow[i].GetListaSamolotow()[j].GetIDSamolotu());
                    }
                }
            }
            else
            {
                Console.WriteLine("Brak samolotow do wyswietlenia");
            }
        }

        /// <summary> Dodaje nowe lotnisko </summary>
        public Boolean DodajLotnisko(string ID)
        {
            if (ListaLotnisk.Count() != 0)
            {
                foreach (Lotnisko Obiekt in ListaLotnisk)
                {
                    if (Obiekt.GetIDLotniska() == ID)
                        return false;
                }
            }

            ListaLotnisk.Add(new Lotnisko(ID));
            return true;
        }
        /// <summary> Usuwa lotnisko o podanym ID </summary>
        public Boolean UsunLotnisko(string ID)
        {
            if (ListaLotnisk.Count() != 0)
            {
                for (int i = 0; i < ListaLotnisk.Count(); i++)
                {
                    if (ListaLotnisk[i].GetIDLotniska() == ID)
                    {
                        ListaLotnisk.Remove(ListaLotnisk[i]);
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary> Wyswietla wszystkie lotniska </summary>
        public void PrzegladLotnisk()
        {
            if (ListaLotnisk.Count() != 0)
            {
                for (int i = 0; i < ListaLotnisk.Count(); i++)
                {
                    Console.WriteLine("Nazwa lotniska: " + ListaLotnisk[i].GetIDLotniska());
                }
            }
            else
            {
                Console.WriteLine("Brak lotnisk do wyswietlenia");
            }
        }

        /// <summary> Dodaje nową trasę </summary>
        public Boolean DodajTrase(Lotnisko L1, Lotnisko L2, int odleglosc)
        {
            if (ListaTras.Count() != 0)
            {
                foreach (Trasa Obiekt in ListaTras)
                {
                    int CzyIstnieje = 0;
                    String[] RozbitaNazwa = Obiekt.GetIDTrasy().Split('-');                   // rozbija ID lotniska na podstawie jego tworzenia a potem sprawdza czy pomiedzy dwoma danymi lotniskami juz jest polaczenia
                    foreach (var Podciag in RozbitaNazwa)
                    {
                        if (String.Compare(Podciag, L1.GetIDLotniska(), true) == 0 || String.Compare(Podciag, L2.GetIDLotniska(), true) == 0)       // truew porownywaniu ignoruje wielkosc znakow
                        {
                            CzyIstnieje++;
                        }
                    }
                    if (CzyIstnieje == 2)
                        return false;
                }
            }

            ListaTras.Add(new Trasa(L1, L2, odleglosc));
            return true;
        }
        /// <summary> Usuwa trasę o podanym ID </summary>
        public Boolean UsunTrase(string ID)
        {
            if (ListaLotnisk.Count() != 0)
            {
                for (int i = 0; i < ListaTras.Count(); i++)
                {
                    if (ListaTras[i].GetIDTrasy() == ID)
                    {
                        ListaLotnisk.Remove(ListaLotnisk[i]);
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary> Wyswietla wszystkie dostepne trasy </summary>
        public void PrzegladTras()
        {
            if (ListaTras.Count() != 0)
            {
                for (int i = 0; i < ListaTras.Count(); i++)
                {
                    Console.WriteLine("Nazwa tarsy: " + ListaTras[i].GetIDTrasy());
                }
            }
            else
            {
                Console.WriteLine("Brak tras do wyswietlenia");
            }
        }
        /// <summary> Dodaje klienta </summary>
        public Boolean DodajKlienta(Klient Nowy)//nie wiem jeszcze jak rozwiazac dodawanie osoby lub posrednika. albo bedzie wybor opcji np przez parametr albo bedzie tworzony oddzielnie a potem dodany na liste
        {
            ListaKlientow.Add(Nowy);
            return true;
        }
        /// <summary> Usuwa klienta o podanym ID </summary>
        public Boolean UsunKlienta(string ID)
        {
            if (ListaKlientow.Count() != 0)
            {
                for (int i = 0; i < ListaKlientow.Count(); i++)
                {
                    if (ListaKlientow[i].GetIDKlienta() == ID)
                    {
                        ListaKlientow.Remove(ListaKlientow[i]);
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary> Wyswietla wszystkich klientow </summary>
        public void PrzegladKlientow()
        {
            if (ListaKlientow.Count() != 0)
            {
                for (int i = 0; i < ListaKlientow.Count(); i++)
                {
                    Console.WriteLine("Klient: " + ListaKlientow[i].GetIDKlienta());
                }
            }
            else
            {
                Console.WriteLine("Brak klientow do wyswietlenia");
            }
        }
        /// <summary> Tworzy osobe </summary>
        public Osoba StworzOsobe(string Imie, string Nazwisko)
        {
            LiczbaOsob++;
            return new Osoba(Imie, Nazwisko, "OS-" + LiczbaOsob.ToString().PadLeft(5, '0'));
        }
        /// <summary> Tworzy posrednika </summary>
        public Posrednik StworzPosrednika(string Nazwa)
        {
            LiczbaPosrednikow++;
            return new Posrednik(Nazwa, "PO-" + LiczbaPosrednikow.ToString().PadLeft(5, '0'));
        }










        /// <summary> Zapisuje stan programu do pliku </summary>
        public void ZapisDoPliku()
        {
            try
            {
                using (Stream strumien = File.Open("dane.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(strumien, ListaLotnisk);
                    bin.Serialize(strumien, ListaTypow);
                    bin.Serialize(strumien, ListaTras);
                    bin.Serialize(strumien, ListaKlientow);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Wystapil blad zapisu danych");
            }
        }
        /// <summary> Odczytuje stan programu z pliku </summary>
        public void OdczytZPliku()
        {
            using (Stream strumien = File.Open("dane.bin", FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();

                ListaLotnisk = (List<Lotnisko>)bin.Deserialize(strumien);
                ListaTypow = (List<TypSamolotu>)bin.Deserialize(strumien);
                ListaTras = (List<Trasa>)bin.Deserialize(strumien);
                ListaKlientow = (List<Klient>)bin.Deserialize(strumien);
            }
        }

    }
}
