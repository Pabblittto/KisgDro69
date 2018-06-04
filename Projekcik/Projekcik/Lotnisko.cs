﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik
{
    /// <summary>
    /// Prosta klasa obiektu lotnisko , posiada tylko id, które jest jego nazwą
    /// </summary>
    [Serializable]
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
