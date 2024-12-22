using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Ogrenci o1 = new Ogrenci();
            o1.dYiliAta(2003);
            Console.WriteLine(o1.dYiliDonder());
            Console.WriteLine(o1.yasDonder());
            o1.yasAta(30);
            Console.WriteLine(o1.dYiliDonder());
            Console.WriteLine(o1.yasDonder());*/

            Ogrenci o1 = new Ogrenci();
            o1.pdYili = 2003;
            Console.WriteLine(o1.pYas);
            Console.WriteLine(o1.pdYili);
            o1.pYas = 37;
            Console.WriteLine(o1.pdYili);
            Console.WriteLine(o1.pYas);

            Console.ReadKey();
        }
    }
}
