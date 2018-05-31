using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    /*
    public class Firma  //klasa statyczna bo bedzie tylko jedna firma
    {
        private List<Lotnisko> ListaLotnisk=new List<Lotnisko>();
        private List<TypSamolotu> ListaTypow=new List<TypSamolotu>();
        private List<Trasa> ListaTras=new List<Trasa>();
        private List<Lot> ListaLotow=new List<Lot>();
        private List<Klient> ListaKlientow=new List<Klient>();
        //szybka notka jeszcze sprobuej ogarnac czy nie da sie jakos tych metod sprowadzic do takiej co by pobierala tylko parametry zeby nie bylo tego samego tysiac razy
        public Boolean DodajTyp(string Nazwa, int _Zasieg, int _Predkosc, int IlMiejsc, int IlMiejscVip)
        {
            if (ListaTypow.Count() != 0)
            {
                foreach (TypSamolotu Obiekt in ListaTypow)
                {
                    if (Obiekt.GetNazwaModelu() == Nazwa)
                        return false;
                }
            }
           
            ListaTypow.Add(new TypSamolotu(Nazwa,_Zasieg,_Predkosc,IlMiejsc,IlMiejscVip));
            return true;
        }
        public Boolean UsunTyp(string NazwaTypu)
        {
            if (ListaTypow.Count() != 0)
            {
                for (int i = 0; i < ListaTypow.Count(); i++)
                {
                    if (ListaTypow[i].GetNazwaModelu() == NazwaTypu)
                    {
                        ListaTypow.Remove(ListaTypow[i]);  //nie jestem pewien czy remove czy delete wiec zostanie na razie remove. jeszcze ogarne
                        return true;
                    }
                }
            }
            return false;
        }
        public void PrzegladTypow()
        {
            if (ListaTypow.Count() != 0)
            {
                for (int i = 0; i < ListaSamolotow.Count(); i++)
                {
                    //wypluwa kolejne typy na ekran
                }
            }
            else
            {
                //wypluwa komunikat o braku typow
            }
            
        }
        public Boolean DodajLotnisko(string id)
        {
            if (ListaLotnisk.Count() != 0)
            {
                foreach (Lotnisko Obiekt in ListaLotnisk)
                {
                    if (Obiekt.GetIDLotniska() == id)
                        return false;
                }
            }

            ListaLotnisk.Add(new Lotnisko(id));
            return true;
        }
        public Boolean UsunLotnisko(string id)
        {
            if (ListaLotnisk.Count() != 0)
            {
                for (int i = 0; i < ListaLotnisk.Count(); i++)
                {
                    if (ListaLotnisk[i].GetIDLotniska() == id)
                    {
                        ListaLotnisk.Remove(i);
                        return true;
                    }
                }
            }
            return false;
        }
        public void PrzegladLotnisk()
        {
            if (ListaLotnisk.Count() != 0)
            {
                for (int i = 0; i < ListaLotnisk.Count(); i++)
                {
                    //wypluwa kolejne lotniska na ekran
                }
            }
            else
            {
                //wypluwa komunikat o braku lotnisk
            }

        }
        public Boolean DodajTrase(Lotnisko L1, Lotnisko L2,int odleglosc)
        {
            if (ListaTras.Count() != 0)
            { 
                foreach (Trasa Obiekt in ListaTras)
                {
                    int CzyIstnieje=0;
                    String[] RozbitaNazwa=Obiekt.GetIDTrasy.Split('-');// rozbija ID lotniska na podstawie jego tworzenia a potem sprawdza czy pomiedzy dwoma danymi lotniskami juz jest polaczenia
                       foreach(var Podciag in RozbitaNazwa)
                    {
                        if(String.Compare(Podciag,L1.GetIDLotniska,true)==0|| String.Compare(Podciag, L2.GetIDLotniska, true) == 0) // truew porownywaniu ignoruje wielkosc znakow
                        {
                            CzyIstnieje++;
                        }
                    }
                    if (CzyIstnieje == 2)
                        return false;
                }
            }

            ListaTras.Add(new Trasa(L1,L2,odleglosc));
            return true;
        }
        public Boolean UsunTrase(string id)
        {
            if (ListaLotnisk.Count() != 0)
            {
                for (int i = 0; i < ListaTras.Count(); i++)
                {
                    if (ListaTras[i].GetIDTrasy() == id)
                    {
                        ListaLotnisk.Remove(i);
                        return true;
                    }
                }
            }
            return false;
        }
        public void PrzegladTras()
        {
            if (ListaTras.Count() != 0)
            {
                for (int i = 0; i < ListaTras.Count(); i++)
                {
                    //wypluwa kolejne trasy na ekran
                }
            }
            else
            {
                //wypluwa komunikat o braku tras
            }

        }
        public Boolean DodajKlienta(Klient nowy)//nie wiem jeszcze jak rozwiazac dodawanie osoby lub posrednika. albo bedzie wybor opcji np przez parametr albo bedzie tworzony oddzielnie a potem dodany na liste
        {
            if (ListaKlientow.Count() != 0)
            {
                foreach (Klient Obiekt in ListaLotnisk)
                {
                    if (Klient.GetIDKlienta() == id)
                        return false;
                }
            }

            ListaLotnisk.Add(nowy);
            return true;
        }
        public Boolean UsunKlienta(string id)
        {
            if (ListaKlientow.Count() != 0)
            {
                for (int i = 0; i < ListaKlientow.Count(); i++)
                {
                    if (ListaKlientow[i].GetIDKlienta() == id)
                    {
                        ListaLotnisk.Remove(i);
                        return true;
                    }
                }
            }
            return false;
        }
        public void PrzegladKlientow()
        {
            if (ListaKlientow.Count() != 0)
            {
                for (int i = 0; i < ListaKlientow.Count(); i++)
                {
                    //wypluwa kolejne lotniska na ekran
                }
            }
            else
            {
                //wypluwa komunikat o braku lotnisk
            }

        }
        public void ZapisDoPliku()//generalnie zastosujemy serializacje zeby zapisywac calosc jeszcze doczytac musze czy to tak zadziala na jednym pliku ew jak to zrobic przy odczycie
        {
            try
            {
                using (Stream strumien = File.Open("dane.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(strumien, ListaLotnisk);
                    bin.Serialize(strumien, ListaTypow);
                    bin.Serialize(strumien, ListaTras);
                    bin.Serialize(strumien, ListaLotow);
                    bin.Serialize(strumien, ListaKlientow);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Wystapil blad zapisu danych");
            }
        } 
        public void OdczytZPliku()   // work in progress
        {
            using (Stream strumien = File.Open("dane.bin", FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();

                ListaLotnisk = List<Lotniska> bin.Deserialize(strumien);
                ListaTypow = List<Typ> bin.Deserialize(strumien);
                ListaTras = List<Trasa> bin.Deserialize(strumien);
                ListaLot = List<Lot> bin.Deserialize(strumien);
                ListaKlientow = List<Klient> bin.Deserialize(strumien);

            }
        }
    }
    */
}
