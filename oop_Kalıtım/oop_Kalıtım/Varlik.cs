using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace oop_Kalıtım
{
    internal class Varlik
    {
        public int yas;
        public int kilo;

        public Varlik()
        {
            Console.WriteLine("Varlık nesnesi oluştu");
        }

        public virtual void hareketEt() //virtual sayesinde çocuklar bunun yeni bir versiyonunu çekirdekte yazabiilirler 
        {
            Console.WriteLine("Varlık gibi hareket ediyor");
        }

        public void sesVer()
        {
            Console.WriteLine("Varlık gibi ses veriyor");
        }
    }
}
