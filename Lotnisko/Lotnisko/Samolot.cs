using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    [Serializable]
    public class Samolot
    {
        private string IDSamolotu;
        private Boolean CzyDostepny;

        /// <summary> Konstruktor samolotu - wykorzystuje ID </summary>
        public Samolot(String ID)
        {
            IDSamolotu = ID;
            CzyDostepny = true;
        }

        /// <summary> Zwraca dostepnosc samolotu </summary>
        public Boolean GetCzyDostepny()
        {
            return CzyDostepny;
        }
        /// <summary> Ustawia dostepnosc samolotu </summary>
        public void SetCzyDostepny(Boolean stan)
        {
            CzyDostepny = stan;
        }
        /// <summary> Zwraca ID samolotuu </summary>
        public string GetIDSamolotu()
        {
            return IDSamolotu;
        }


        /// <summary> Zmienia dostępność samolotu na przeciwną </summary>
        public void ZmianaDostepu()
        {
            CzyDostepny = !CzyDostepny;
        }
    }
}