using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marias
{
    class Osztas
    {
        private Pakli pakli = new Pakli();
        public Pakli GetPakli { get { return pakli; } }

        public void Oszt(Jatekos p1, Jatekos p2)
        {
            pakli.Kever(10);
            for (int i = 0; i != 5; i++)
            {
                p1.KartyatAd(pakli.Huz());
                p2.KartyatAd(pakli.Huz());
            }
        }


    }
}
