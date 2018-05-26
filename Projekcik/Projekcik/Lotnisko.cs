using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
   public class Lotnisko
    {
        private string IDLotniska;


        public Lotnisko(string ID)
        {
            IDLotniska = ID;
        }

        public string GetIDLotniska()
        {
            return IDLotniska;
        }
    }
}
