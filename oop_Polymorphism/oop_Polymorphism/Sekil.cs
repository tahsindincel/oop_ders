using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop_Polymorphism
{
    internal class Sekil
    {
        public virtual void Ciz()
        {
            Console.WriteLine("Şekil çizildi");
        }
    }

    class Kare : Sekil
    {
        public new void Ciz()// böyle yaparsak Ciz() fonksiyonu atası gibi davranır. Kendi gibi davranmasını istiyorsak overroad kullanmalıydık
        {
            Console.WriteLine("Kare çizildi");
        }
    }

    class Ucgen : Sekil
    {
        public override void Ciz()
        {
            //base.Ciz() demek ata sınıfın Ciz() methodunu burda kullan demektir
            Console.WriteLine("Üçgen çizildi");
        }
    }
}
