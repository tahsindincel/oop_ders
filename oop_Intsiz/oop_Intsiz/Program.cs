using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Intsiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koro RedArmyChoir = new Koro();
            Insan i = new Insan();
            Robot BumbleBee = new Robot();
            RedArmyChoir.sesVerenEkle(i); // insan sınıfın içine sesVer fonksiyonu yazmamız yetmez bunu sertifikalandırmalıyız. bunu da abstract ile yaparız
            RedArmyChoir.sesVerenEkle(new Kus());
            RedArmyChoir.sesVerenEkle(new Piyano());

            RedArmyChoir.koroSoylesin();

            DansGrubu Grup1 = new DansGrubu();
            Grup1.dansEdenEkle(i);

            Console.ReadKey();
        }
    }
}
