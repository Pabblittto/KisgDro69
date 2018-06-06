using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    [Serializable]
    /// <summary>
    /// Klasa która jednocześnie jest rezerwacją i biletem
    /// </summary>
    public class RezerwcjaBilet
    {
        private Klient Pasazer;

        private string NrRezerwacjiBiletu;
        private uint NrMiesca;
        private int CenaBiletu;
        private Boolean BiletVIP;
        private Boolean CzyKupionyBilet;

        private DateTime DataWygasniecia;

        /// <summary>
        /// Konstruktor rezerwacji.
        /// Ostatnia zmienna mówi czy bilet jest od razu kupowany.
        /// </summary>
        public RezerwcjaBilet(string NrRezerwacji, int _Cena, Boolean VIP, Klient KtoRezerwuje, DateTime DataStworzenia, Boolean _CzyKupionyBilet)
        {
            Pasazer = KtoRezerwuje;
            NrRezerwacjiBiletu = NrRezerwacji;
            NrMiesca = (uint)new System.ComponentModel.UInt32Converter().ConvertFromString("0x" + NrRezerwacji.Split('-')[1]);
            CenaBiletu = _Cena;
            BiletVIP = VIP;
            DataWygasniecia = DataStworzenia.Add(new TimeSpan(7, 0, 0, 0));// czas rezerwacji , rezerwacje można zrobić tylko na 7 dni                                                        // jeżeli data wygaśniećia bedzie się równać dacie w programie to rezerwacja jest usuwana z listy rezerwacji
            CzyKupionyBilet = _CzyKupionyBilet;
        }

        /// <summary> Zwraca numer rezerwacji </summary>
        public string GetNrRezerwacji()
        {
            return NrRezerwacjiBiletu;
        }
        /// <summary> Zwraca czy bilet jest typu VIP </summary>
        public Boolean CzyVIP()
        {
            return BiletVIP;
        }
        /// <summary> Zwraca numer miejsca </summary>
        public uint GetNrMiejsca()
        {
            return NrMiesca;
        }
        /// <summary> Zwraca czy dany obiekt jest rezerwacją czy biletem </summary>
        /// <returns></returns>
        public Boolean CzyJestToBilet()
        {
            return CzyKupionyBilet;
        }
        /// <summary>
        /// Sprawia że rezerwacja staje się biletem i data wygaśnięcia już nie obowiązuje
        /// </summary>
        public void WykupRezerwacje()
        {
            CzyKupionyBilet = true;
        }

        /// <summary>
        /// Funkcja zwracająca czy data wygaścnięcia mineła czy nie, zwraca true jeżeli rezerwacja wygasła.
        /// false- nie wygasła jeszcze- przyda się jak trzeba wywalac rezerwacje po czasie wygaśnięcia
        /// </summary>
        /// <param name="DatawProgramie">Wirtualna data w programie</param>
        /// <returns></returns>
        public Boolean CzyWygaslo(DateTime DataWProgramie)
        {
            if (CzyKupionyBilet == false)
            {
                if (DataWygasniecia.CompareTo(DataWProgramie) <= 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
