using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_ArrayStr
{
    internal class Personel:IComparable
    {
        int sicil;
        string ad;
        string soyad;

        public Personel(int sn, string a, string syd)
        {
            sicil = sn;
            ad = a;
            soyad = syd;
        }

        public void yaz()
        {
            Console.WriteLine($"{sicil}:{ad} {soyad}");
        }

        public int CompareTo(object o)
        {
            Personel p = (Personel) o;
            return sicil.CompareTo( p.sicil );
        }
    }
}
