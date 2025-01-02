using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_ArrayStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 3, -5, 10, 0, 35, 10, 2 };
            string[] isimler = { "Tahsin", "Aziz", "Emino", "Batu" };
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
                Console.WriteLine(sayilar[i]);

            Array.Sort(isimler);
            for (int i = 0;i < isimler.Length; i++)
                Console.WriteLine(isimler[i]);

            Personel[] personeller = new Personel[4];
            personeller[0] = new Personel(474477, "Tahsin", "Dinçel");
            personeller[1] = new Personel(129754, "Aziz", "Ağrakçe");
            personeller[2] = new Personel(814650, "Batu", "Can");
            personeller[3] = new Personel(356987, "Emin", "Baykara");

            for (int i = 0; i < personeller.Length; i++)
                personeller[i].yaz();

            Array.Sort(personeller);
            Console.WriteLine("Sıralama sonrası");
            for (int i = 0;i<personeller.Length;i++)
                personeller[i].yaz();


            Console.ReadKey();
        }
    }
}
