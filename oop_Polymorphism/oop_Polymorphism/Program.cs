using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sekil[] sekiller = new Sekil[3];
            sekiller[0] = new Sekil();
            sekiller[1] = new Kare();
            sekiller[2] = new Ucgen();

            for(int i = 0;i<3;i++)
            {
                sekiller[i].Ciz();
                //hepsi şekil olmasına rağmen hepsi farklı davranışlar sergiliyoor buna polymorphism denir. -çok şekillilik-
            }

            Console.ReadKey();
        }
    }
}
