using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    /// <summary>
    /// Klasa Lotnisko zawierająca jego ID
    /// </summary>
    [Serializable]
    public class Lotnisko
    {
        private string IDLotniska;

        /// <summary> Konstruktor lotniska - wykorzystuje ID </summary>
        public Lotnisko(string ID)
        {
            IDLotniska = ID;
        }
        /// <summary> Zwraca ID lotniskay </summary>
        public string GetIDLotniska()
        {
            return IDLotniska;
        }
    }
}