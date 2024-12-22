using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Varlik v1 = new Varlik();
            //v1.hareketEt();
            Kedi suphi = new Kedi();
            Varlik v2 = suphi;
            suphi.hareketEt();
            suphi.sesVer();
            v2.hareketEt(); //v2 yi kediden türettik ve hareketEt() metodunu orda değiştirmiştik bu yüzden de burda kedi gibi hareket edecek
            v2.sesVer();


            Console.ReadKey();
        }
    }
}
