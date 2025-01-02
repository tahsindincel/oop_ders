using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_donusum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            double b = a; //implicit dönüşüm
            short c = (short)b; //explicit dönüşüm

            //dersin konusu: kendi yazdığımız nesneler arasında dönüşüm yapmak. (bkz:kitabı kaleme dönüştürmek), kendi yaazzdığımız kesir sınıfını tam sayıya dönüştürme

            Kesir k0 = new Kesir(10, 7);
            Kesir k1 = new Kesir(7,2);
            int d = (int)k1;
            Console.WriteLine(d);

            Kesir k2 = (Kesir)8; //burda bir tamsayıyı kesire dönüştürmek istiyoruz
            k2.kesirYazdir();


            Kesir k3 = k1 + k0;
            Console.WriteLine(k3);

            Kesir k4 = new Kesir(14, 4);

            if (k1 == k4)
                Console.WriteLine("eşittir");
            else 
                Console.WriteLine("eşit değil");



            Console.ReadKey();
        }
    }
}

//ÖDEV: karmaşık sayıları tam sayıya tam sayıları karmaşık sayıya çeviren bir explicit implicit dönüşümler yapan bir sınıf yaz