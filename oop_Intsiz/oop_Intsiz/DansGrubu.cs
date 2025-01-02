using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Intsiz
{
    internal class DansGrubu
    {
        dansEdebilenler[] dansgrup = new dansEdebilenler[10];
        int eklenens = 0;

        public void dansEdenEkle(dansEdebilenler danscı)
        {
            dansgrup[eklenens++] = danscı;
        }

        public void dansBaslasin()
        {
            for (int i = 0; i < eklenens; i++)
            {
                dansgrup[i].dansEt();
            }
        }
    }
}
