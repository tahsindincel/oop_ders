using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Intli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koro BogaziciCaz = new Koro();
            Dans dansgrubu = new Dans();
            BogaziciCaz.sesVerenEkle(new Insan());
            BogaziciCaz.sesVerenEkle(new Kus());
            BogaziciCaz.sesVerenEkle(new Piyano());
            BogaziciCaz.koroSoylesin();

            Console.WriteLine("\n****************\n");
            dansgrubu.dansciEkle(new Robot());
            dansgrubu.dansciEkle(new Insan());
            dansgrubu.dansBaslasin();

            Console.ReadKey();
        }
    }
}
