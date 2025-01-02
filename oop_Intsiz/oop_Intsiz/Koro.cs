using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Intsiz
{
    internal class Koro //ilerde bir değişiklik yapmama gerek kalmayacak bu da bu sınıfın open-close prensibine uygun olduğunu gösterir
    {
        sesVerenler[] topluluk = new sesVerenler[10];
        int eklenens = 0;

        public void sesVerenEkle(sesVerenler birey) //dependency of inversion
        {
            topluluk[eklenens++] = birey;
        }

        public void koroSoylesin()
        {
            for (int i = 0;i<eklenens;i++)
            {
                topluluk[i].sesVer(); //polymorphism
            }
        }
    }
}
