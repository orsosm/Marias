using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marias
{
    public enum Szin
    {
        Zold, Makk, Tok, Piros
    }

    public enum Figura
    {
        Also = 2,
        Felso = 3,
        Kiraly = 4,
        Asz = 11,
        Hetes = 7,
        Nyolcas = 8,
        Kilences = 9,
        Tizes = 10
    }

    class Kartya
    {
        //adattagok
        private readonly Szin szin;
        private readonly Figura figura;
       

        //propertyk
        public Szin Szin { get {return szin;} }
        public Figura Figura { get { return figura; } }
        public int Ertek { get { return (int) figura; }  }

        //konstruktor
        public Kartya(Szin szin, Figura figura)
        {
            this.szin = szin;
            this.figura = figura;
            int ertek = (int)figura;
        }

    }
}
