using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marias
{
    class Pakli
    {
        //adattagok
        private List<Kartya> kartyak = new List<Kartya>();
        private Random random;

        //Propertyk
        public Kartya this[int pozicio] { get { return (Kartya)kartyak[pozicio]; } }
        public int Kartyak { get { return kartyak.Count; } }

        //Konstruktor
        public Pakli()
        {
            foreach (Szin s in Enum.GetValues(typeof(Szin)))
            {
                foreach (Figura f in Enum.GetValues(typeof(Figura)))
                {
                    kartyak.Add(new Kartya(s, f));
                }
            }
            random = new Random();
        }

        //Metódusok
        public Kartya Huz()
        {
            Kartya kartya = kartyak[0];
            kartyak.RemoveAt(0);

            return kartya;
        }

        public void Kever()
        {
            for (int n =0;n!=1;n++)
            {
                for (int i=0;i<kartyak.Count;i++)
                {
                    int index1 = i;
                    int index2 = random.Next(kartyak.Count);

                    KartyaCsere(index1, index2);
                }
            }
        }

        public void Kever(int hanyszor)
        {
            if (hanyszor ==0)
            {
                Console.WriteLine("Legalább egyszer keverni kell!");
            }
            else
            {
                for (int n=0;n!=hanyszor;n++)
                {
                    for (int i=0;i!=kartyak.Count;i++)
                    {
                        int index1 = i;
                        int index2 = random.Next(kartyak.Count);

                        KartyaCsere(index1, index2);
                    }
                }
            }
        }

        public void kiir()
        {
            for (int i=0;i<kartyak.Count;i++)
            {
                Console.WriteLine("{0} {1}; ",kartyak[i].Szin,kartyak[i].Figura);
            }
            Console.WriteLine();
        }

        private void KartyaCsere(int index1, int index2)
        {
            Kartya kartya = kartyak[index1];
            kartyak[index1] = kartyak[index2];
            kartyak[index2] = kartya;
        }

    }
}
