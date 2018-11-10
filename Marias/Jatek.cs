using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marias
{
    class Jatek
    {
        private Jatekos p1 = new Jatekos();
        private Jatekos p2 = new Jatekos();
        private Pakli pakli = new Pakli();
        private Osztas osztas = new Osztas();
        
        

        public Jatek()
        {
            osztas.Oszt(p1, p2);
        }

        public void AllasKiir()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. játékos (Pontszám: {0})", p1.Pontszam);
            Console.ForegroundColor = ConsoleColor.White;
            p1.KartyaKiir();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n2. játékos (Pontszám: {0})", p2.Pontszam);
            Console.ForegroundColor = ConsoleColor.White;
            p2.KartyaKiir();
        }
        //Innen folytatni!!!!
        public void ValasztastBeker_P1(int jatekosNr)
        {
            
                Console.Write("Játékos 1: Tegyél le egy kártyát: ");
                p1valasztas = char.Parse(Console.ReadLine());
                if (p1valasztas != 'q')
                {
                    p1.KartyatELvesz(p1valasztas);
                }
                else if (p1valasztas == 'q')
                {
                    vege = true;
                }
            
        }
        private void Csata(Jatekos p1, Jatekos p2, int p1valasztas, int p2valasztas)
        {
            Kartya p1Kartya = p1.KartyatELvesz(p1valasztas);
            Kartya p2Kartya = p2.KartyatELvesz(p2valasztas);

            if (p1Kartya.Szin == p2Kartya.Szin)
            {
                if (p1Kartya.Ertek > p2Kartya.Ertek)
                {
                    p1.KartyatVisz(p1Kartya);
                    p1.KartyatVisz(p2Kartya);
                }
                else
                {
                    p2.KartyatVisz(p1Kartya);
                    p2.KartyatVisz(p2Kartya);
                }
            }
        }

        public void JatekMegy()
        {
            char p1valasztas, p2valasztas;
            bool vege = false;
            while (!vege)
            {
                AllasKiir();
                

                Console.Write("Játékos 2: Tegyél le egy kártyát: ");
                p2valasztas = char.Parse(Console.ReadLine());
                if (p2valasztas != 'q')
                {
                    p2.KartyatELvesz(p2valasztas);
                }
                else if (p2valasztas == 'q')
                {
                    vege = true;
                }
                Csata(p1, p2, p1valasztas, p2valasztas);

            }


           

           
            

        }
    }
}
