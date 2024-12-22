using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Generic_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiziIslemleri<int> nesne = new DiziIslemleri<int>();
            nesne.Ekle(5);
            nesne.Ekle(10);
            int a = nesne.elemanDonder(0);
            Console.WriteLine(a);


            Console.ReadKey();
                
        }
    }

    class DiziIslemleriInt
    {
        int[] dizi = new int[20];
        int eklenens = 0;

        public void Ekle(int a)
        {
            dizi[eklenens++] = a;
        }

        public int elemanDonder(int indis)
        {
            return dizi[indis];
        }
    }

    class DiziIslemleriStr
    {

        string[] dizi = new string[20];
        int eklenens = 0;

        public void Ekle(string a)
        {
            dizi[eklenens++] = a;
        }

        public string elemanDonder(int indis)
        {
            return dizi[indis];
        }
    }

    //yukarda int ve string için aynı işlemler yapılıyor bunlar için ayrı ayrı sınıf oluşturmaya gerek yok. Genel bir sınıf yazalım T diyelim T yerine ne gerekiyorsa eklesin
    class  DiziIslemleri <T> // T burada joker gibi görev yapar
    {
        T[] dizi = new T[20];
        int eklenens = 0;

        public void Ekle(T a)
        {
            dizi[eklenens++] = a;
        }

        public T elemanDonder(int indis)// istersek burada int indis yerine başka bir  harfi joker olarak verip oranın da dışardan parametre olarak verilmesini sağlayabiliriz
        {                               // bunu yaparken de örneğin D için sınıf adının yanına <T,D> şeklinde yazarız
            return dizi[indis];
        }

    }


}
