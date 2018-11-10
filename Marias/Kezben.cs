using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marias
{
    class Kezben
    {
        //adattagok
        private List<Kartya> kartyak = new List<Kartya>();

        //propertyk
        public int NumKartyak { get { return kartyak.Count; } }
        public List<Kartya> Kartyak { get { return kartyak; } }

        //Metódus
        public bool KezbenVan(Figura elem)
        {
            foreach (Kartya k in kartyak)
            {
                if (k.Figura == elem)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
