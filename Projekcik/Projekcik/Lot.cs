using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    [Serializable]
    public class Lot
    {
         private string IDLotu;
         private string IDSamolotu;// id konkretnego zamolotu, który obsługuje lot 

         private List<Rezerwacja> ListaRezerwacji; // lista rezerwacji określa również liste/liczbe klientów lecących tym samolotem
       

        private Trasa Droga;
        private TypSamolotu Pojazd;// typ samolotu, ponieważ on przechowuje prekość, ładowność itd.
        private TimeSpan CzasLotu; //  ten czas jest liczony i wklepywany przez funkcje
        private DateTime DataGodzinaWylotu;

        


        public Lot(string ID, Trasa _Droga,int RokWylot,int MiesWyl,int DzienWyl, int GodzWyl, int MinWyl)
        {
            ListaRezerwacji = new List<Rezerwacja>();
            IDLotu = ID;
            Droga = _Droga;
            DataGodzinaWylotu = new DateTime(RokWylot, MiesWyl, DzienWyl, GodzWyl, MinWyl,0);//ostatnia liczna to sekundy- nieistotna wartość w programie
            Pojazd = null;// to też pomaga stwierdzić czy istnieje samolot który jest zapisany do trasy
            CzasLotu = new TimeSpan(0, 0, 0);//dzięki temu wiemy że na początku nie ma konkretnego samolotu który obsługuje ta trase

        }
        /// <summary>
        /// konstruktor kopiujący, jeżeli chcemy zrobić taki sam lot przesunięty w czasie o Jakiś przedział czasu(trzeba iwedzieć jak Tworzyć TimeSpan)
        /// </summary>
        public Lot(Lot IstniejącyLot,TimeSpan OjakiCZasPrzesuniety, String _IDLotu)
        {
            ListaRezerwacji = new List<Rezerwacja>();
            IDLotu = _IDLotu;
            Droga = IstniejącyLot.GetDroga();
            DataGodzinaWylotu = IstniejącyLot.GetDataWylDT();
             DataGodzinaWylotu= DataGodzinaWylotu.Add(OjakiCZasPrzesuniety);
            Pojazd = null;
            CzasLotu = new TimeSpan(0, 0, 0);

        }


        /// <summary>
        ///  Z racji że typ samolotu ma dany zasięg, trzeba sprawdazć czy dany samolot nadaje się do lotu 
        ///  dla konkretnej trasy, podawy jest od razu id samolotu, bardzo ważna funkcja, bez niej lot nie mam maszyny!!
        ///  funkcja od razu liczy nowy czas przelotu danej trasy
        /// </summary>
        /// <returns></returns>
        public Boolean SetPojazd(TypSamolotu TypPojazdu,string IDPojazdu)        //  nie jest w konstruktorze ponieważ zwraca booleana
        {
            if (TypPojazdu.GetZasieg() >= Droga.GetOdleglosc() && TypPojazdu.GetSAmolotOID(IDPojazdu).GetCzyDostepny()==true)
            {
                Pojazd = TypPojazdu;
                IDSamolotu = IDPojazdu;
                double czas = Droga.GetOdleglosc() / Pojazd.GetPredkosc();// czas wychodzi w godz z minutamie po przecinku
                czas = Math.Round(czas, 2);
                double min = (czas % 1) * 60;// minuty w formiacie 0,xx więc trzeba pomnożyć razy 60
                CzasLotu = new TimeSpan((int)czas,(int)min,0);// zero na końcu- to sekundy nieistotne w programie
                return true;
            }
            else
                return false;
        }


        public int GetIloscMiejscWolnychZwyklych()
        {
            if (Pojazd != null)
            {
                if (ListaRezerwacji.Count() != 0)
                {
                    int liczba = 0;
                    foreach (Rezerwacja Objekt in ListaRezerwacji)
                    {
                        if (Objekt.CzyVIP() == false)
                            liczba++;
                    }

                    return Pojazd.GetIloscMiejsc() - liczba;
                }
                else
                    return Pojazd.GetIloscMiejsc();
            }
            else
                throw new Wyjatek("Nie został dodany samolot obsłudujący ten lot!!");// niech uzytkownik wypełni pole samolotu!! niech w ekstrymalnych przypadkach program usuwa                                                                           // dany lot żebby problemy się nie robiły
        }


        public int GetIloscMiejscWolnychVip()
        {
            if (Pojazd != null)
            {
                if (ListaRezerwacji.Count() != 0)
                {
                    int liczba = 0;
                    foreach (Rezerwacja Objekt in ListaRezerwacji)
                    {
                        if (Objekt.CzyVIP() == true)
                            liczba++;
                    }

                    return Pojazd.GetIloscMiejscVip() - liczba;
                }
                else
                    return Pojazd.GetIloscMiejscVip();
            }
            else
                throw new Wyjatek("Nie został dodany samolot obsłudujący ten lot!!");                                                                         // dany lot żebby problemy się nie robiły
        }

        public string GetIDLotu()
        {
            return IDLotu;
        }

        public Trasa GetDroga()
        {
            return Droga;
        }

        /// <summary>
        /// Data wylotu podana w Stringu
        /// </summary>
        /// <returns></returns>
        public string GetDataWylS() 
        {
            return DataGodzinaWylotu.ToString();
        }

        /// <summary>
        /// Data wylotu podana w DateTime
        /// </summary>
        /// <returns></returns>
        public DateTime GetDataWylDT()
        {
            return DataGodzinaWylotu;
        }

        /// <summary>
        /// zwraca obiekt samolotu, który obsługuje trase- może się przydać
        /// </summary>
        /// <returns></returns>
        public Samolot GetSamolot() 
        {
            if (Pojazd != null)
            {
                foreach (Samolot Obiekt in Pojazd.GetListaSamolotow())
                {
                    if (Obiekt.GetIDSamolotu() == IDSamolotu)
                        return Obiekt;
                }
            }
            throw new Wyjatek("Nie ma Samolotu na liście typów !!");// bardzo specyficzny wyjątek , ktoś usuną samolot, który obsługiwał tą trasę co powinno być nie możliwe-
                                                                    // w catchu proponuje napisać krótką funkcję zmieniającą pole "Pojazd" na null!!!-Ważne
        }


        public String DataPowrotu() 
        {
            if (Pojazd != null)
            {
                DateTime cont = DataGodzinaWylotu.Add(CzasLotu);
                return cont.ToString();
            }
            else
                throw new Wyjatek("Nie został dodany samolot obsłudujący ten lot!!");// w cathu jakiś komunikat dla uzytkownika żeby dodał samolot-Wazne
        }

        public Boolean Rezerwuj()
        {



        }



    }
}
