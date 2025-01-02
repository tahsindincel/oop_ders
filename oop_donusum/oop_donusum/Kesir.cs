using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_donusum
{
    internal class Kesir
    {
        int pay;
        int payda;

        public Kesir(int p, int pd)
        {
            pay = p;
            payda = pd;
        }

        public void kesirYazdir()
        {
            Console.WriteLine($"{pay}/{payda}");
        }

        //dönüşümü yazmak için public+static+ implicit veya explicit+operator+neye(neyi)
        //neye tipiyle uyumlu bir değer üretilerek return edilir

        public static explicit operator int(Kesir k)
        {
            int sonuc = k.pay / k.payda; ;
            return sonuc;
        }

        public static implicit operator Kesir(int k)
        {
            Kesir sonuc = new Kesir(k, 1);
            return sonuc;
        }

        public static Kesir operator +(Kesir k1, Kesir k2)
        {
            int p = k1.pay * k2.payda + k2.pay * k1.payda;
            int pd = k1.payda * k2.payda;
            Kesir sonuc = new Kesir(p, pd);
            return sonuc;
        }

        public static bool operator==(Kesir k1, Kesir k2) //sadece == yazınca hat alırız çünkü bunu eşleniği olan != ifadesini de yazmalıyız
        {
            double s1 = (double)k1.pay/k1.payda;
            double s2 = (double)k2.pay/k2.payda;
            return s1 == s2;
        }

        public static bool operator!=(Kesir k1, Kesir k2)
        {
            return !(k1 == k2);
        }
    }
}
