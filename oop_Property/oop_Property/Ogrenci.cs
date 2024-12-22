using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Property
{
    internal class Ogrenci
    {
        int dYili;
        int Yas;

        public int pdYili
        { get { return dYili; } 
            set {//kontrol etmek istediğin işlemleri de yap
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException();
                else
                    dYili = value;

                Yas = DateTime.Now.Year - dYili;
                    }
        }

        public int pYas
        { get { return Yas; }
            set 
            {if (value <0)
                    throw new ArgumentException();
            else
                Yas = value;

            Yas = DateTime.Now.Year - dYili;
            }
        }

        public void dYiliAta(int dy)
        {
            //kontrol mekanizmalarından geçir 
            //atama ile birlikte yapilması istenen işlemler varsa onları da yap
            if (dy < 1900 || dy > DateTime.Now.Year)
                throw new ArgumentException();
            else
                dYili = dy;

            Yas = DateTime.Now.Year-dYili;
        }

        public int dYiliDonder()
        {
            //hesaplama ile oluşabilen veya içerideki belli bir değeri dönderilir
            return dYili;
        }

        public void yasAta(int y)
        {
            //kontrol mekanizmalarından geçir
            //atama ile birlikte yapılması istenen işlemelr varsa onları da yap
            if(y<0)
                throw new ArgumentException();
            else
                Yas = y;

            dYili = DateTime.Now.Year - y;
        }

        public int yasDonder()
        {
            return Yas;
        }
    }
}
