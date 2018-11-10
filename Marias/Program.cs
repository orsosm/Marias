using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marias
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Title = "Máriás Játék - féléves feladat - WOR1N7 - OE NIK 2018";
            Jatek j = new Jatek();

            j.JatekMegy();

            Console.WriteLine("A kilépéshez nyomj ENTER-t!");
            Console.ReadLine();

        }
    }
}
