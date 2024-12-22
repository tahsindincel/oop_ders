using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Kalıtım
{
    internal class Kedi:Varlik //burda kalıtım yaptık
    {
        public string turu;
        public Kedi()
        {
            Console.WriteLine("Kedi nesnesi oluştu ");
        }

        public void ipleOyna()
        {
            Console.WriteLine("Kedi iple oynuyor");
        }

        public void fareTut()
        {
            Console.WriteLine("Kedi fare tuttu");
        }

        public new void sesVer() // bu fonksiyonu kalıtım olarak almıştık. başına new yazarsak complier uyarı vermez. Metodu kabuktan çağırırız bu yüzden de çekirdekteki çalışmaz
        {
            Console.WriteLine("Miyav");
        }

        public override void hareketEt()//override sayesinde miras aldığımız, çekirdekteki bir fonksiyonu değiştirebiliyoruz
        {
            Console.WriteLine("Kedi hareket ediyor");
        }
    }
}
