using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Intli
{
    internal class Dans
    {
        Idansedebilenler[] danscilar = new Idansedebilenler[10];
        int eklenens = 0;

        public void dansciEkle(Idansedebilenler birey)
        {
            danscilar[eklenens++] = birey;
        }

        public void dansBaslasin()
        {
            for (int i = 0; i < eklenens; i++)
            {
                danscilar[i].dansEt();
            }
        }
    }
}
