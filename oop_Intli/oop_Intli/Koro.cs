using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop_Intli
{
    internal class Koro
    {
        Isesverebilenler[] topluluk = new Isesverebilenler[10];
        int eklenens = 0;

        public void sesVerenEkle(Isesverebilenler birey)
        {
            topluluk[eklenens++] = birey;
        }

        public void koroSoylesin()
        {
            for (int i = 0;i<eklenens;i++)
            {
                topluluk[i].sesVer();
            }
        }
    }
}
