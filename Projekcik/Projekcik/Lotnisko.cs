using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    class Lotnisko
    {
        private String IDLotniska;


        public Lotnisko(String ID)
        {
            IDLotniska = ID;
        }

        public String GetIDLotniska()
        {
            return IDLotniska;
        }
    }
}
