using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marias
{
    class Jatekos
    {
        //adattagok
        private string sPakli;
        private Pakli aktPakli;
        private List<Kartya> kartyak = new List<Kartya>();
        private List<Kartya> nyertKartya = new List<Kartya>();
        private int pontszam, pozicio = 0;
        private int Nyert = 0, Veszitett = 0;
        private string kartyaTulajdonsag = "";

        //propertyk
        public Pakli AktPakli { get { return aktPakli; } set { aktPakli = value; } }
        public int KartySzam { get { return kartyak.Count; } }
        public int GetNyert { get { return Nyert; } }
        public int GetVeszitett { get { return Veszitett; } }
        public int Pontszam { get { return pontszam=NyertKartyaPontszam(); } }
        public string KartyaTulajdonsag { get { return kartyaTulajdonsag = KartyaProp(pozicio); } }
       

        //Metódusok
        public void KartyatAd(Kartya k)
        {
            kartyak.Add(k);
        }

        public Kartya KartyatELvesz(int pozicio)
        {
            Kartya kartya = kartyak[0];
            kartyak.RemoveAt(pozicio);
            return kartya;
        }

        public void KartyatVisz(Kartya k)
        {
            nyertKartya.Add(k);
        }

        public void KartyaKiir()
        {
            for (int i=0;i<kartyak.Count;i++)
            {
                Console.WriteLine("("+i+"). "+kartyak[i].Szin+" "+kartyak[i].Figura);
            }
        }

        public void NyertKartyaKiir()
        {
            for (int i = 0; i < nyertKartya.Count; i++)
            {
                Console.WriteLine(nyertKartya[i].Szin + " " + nyertKartya[i].Figura);
            }
        }

        private int NyertKartyaPontszam()
        {
            for (int i = 0; i < nyertKartya.Count; i++)
            {
                pontszam += nyertKartya[i].Ertek;
               // Console.WriteLine(nyertKartya[i].Szin + " " + nyertKartya[i].Ertek);
            }
           return pontszam;
        }

        private string KartyaProp(int pozicio)
        {
            string vissza;
            
            vissza = kartyak[pozicio].Szin + " " + kartyak[pozicio].Figura;
            return vissza;
        }

    }
}
