using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    [Serializable]
    public abstract class Klient
    {
        private string IDKlienta;
        private List<Bilet> ListaBiletow;

        public Klient(string ID)
            {
            IDKlienta=ID;
            }
        public string GetIDKlienta()
            {
            return IDKlienta;
            }

        public List<Bilet> GetListaBiletow()
        {
            return ListaBiletow;
        }

        /// <summary>
        /// Funkcja zwracająca fałsz jak chcemy dodać bilet który już jest na liśćie
        /// nie wiem czy się przyda ale tak na wszelki wypadek już jest XD
        /// </summary>
        /// <returns></returns>
        public Boolean DodajBilet(Bilet DodawanyBilet) 
        {
            if(ListaBiletow.Count() !=0)
            {
                foreach (Bilet Obiekt in ListaBiletow)
                {
                    if (Obiekt ==DodawanyBilet)
                        return false;

                }
            }
            ListaBiletow.Add(DodawanyBilet);
            return true;
        }

        /// <summary>
        /// Funkcja do usuwania biletów, zwraca fałsz jeżeli nie ma danego biletu na liście 
        /// zwraca prawde jeżeli usuwany bilet był na liście i usuną dany bilet
        /// </summary>
        /// <param name="UsuwanyBilet"></param>
        /// <returns></returns>
        public Boolean UsunBilet(Bilet UsuwanyBilet)
        {
            if (ListaBiletow.Count() != 0)
            {
                foreach (Bilet Obiekt in ListaBiletow)
                {
                    if (Obiekt == UsuwanyBilet)
                    {
                        ListaBiletow.Remove(UsuwanyBilet);
                        return true;
                    }             
                }
            }
            return false;
        }



    }
}
