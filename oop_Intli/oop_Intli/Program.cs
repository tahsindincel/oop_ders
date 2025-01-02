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
            Koro RedArmyChoir = new Koro();
            Dans dansgrubu = new Dans();
            RedArmyChoir.sesVerenEkle(new Insan());
            RedArmyChoir.sesVerenEkle(new Kus());
            RedArmyChoir.sesVerenEkle(new Piyano());
            RedArmyChoir.koroSoylesin();

            Console.WriteLine("\n****************\n");
            dansgrubu.dansciEkle(new Robot());
            dansgrubu.dansciEkle(new Insan());
            dansgrubu.dansBaslasin();

            Console.ReadKey();
        }
    }
}
