using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Singleton_odev
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Baglanti b1 = Baglanti.baglantidonder();
            Baglanti b2 = Baglanti.baglantidonder();
            Baglanti b3 = Baglanti.baglantidonder();
            Baglanti b4 = Baglanti.baglantidonder();
            Baglanti b5 = Baglanti.baglantidonder();
            Baglanti b6 = Baglanti.baglantidonder();

            b1.a = 10;
            b2.a = 20;
            b3.a = 30;
            b4.a = 40;
            b5.a = 50;

            Console.WriteLine(b1.a);
            Console.WriteLine(b2.a);
            Console.WriteLine(b3.a);
            Console.WriteLine(b4.a);
            Console.WriteLine(b5.a);
            Console.WriteLine(b6.a);
            Console.ReadLine();
        }

        class Baglanti
        {
            public int a;
            static Baglanti tekil;
            private const int maks = 5;
            private static List<Baglanti> nesneListesi = new List<Baglanti>();
            private static int mevcutIndex = 0;


            private Baglanti() 
            {
                //dışardan çağırmayı engelledik
            }

            static Baglanti()
            {
                tekil = new Baglanti();
            }

            public static Baglanti baglantidonder()
            {
                if(nesneListesi.Count < maks)
                {
                    Baglanti yenibaglanti = new Baglanti();
                    nesneListesi.Add(yenibaglanti);
                }
                Baglanti donenBaglanti = nesneListesi[mevcutIndex];
                mevcutIndex = (mevcutIndex + 1) % maks;

                return donenBaglanti;
            }



        }
    }
}
