using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    public class Samolot
    {
        private string IDSamolotu;

        private Boolean CzyDostepny;

        public Samolot(String ID)
        {
            IDSamolotu = ID;
            CzyDostepny = true;
        }

        public string GetIDSamolotu()
        {
            return IDSamolotu;
        }

        public Boolean GetCzyDostepny()
        {
            return CzyDostepny;
        }

        public void SetCzyDostepny(Boolean stan)
        {
            CzyDostepny = stan;
        }

        /// <summary>
        /// Funkcja prosta i może sie przydać zarówno do automatycznego wysyłania samolotów w powietrze jak 
        /// i do sprowadzania samolotów na ziemie, zmienia stan CzyDsotepny na przeciwny, ewentualnie wywalić
        /// </summary>
        public void ZmianaDostepu()
        {
            CzyDostepny = !CzyDostepny;
        }


    }
}
