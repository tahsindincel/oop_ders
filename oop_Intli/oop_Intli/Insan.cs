using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Intli
{
    internal class Insan:Isesverebilenler,Idansedebilenler
    {
        public void sesVer()
        {
            Console.WriteLine("Insan sesVer");
        }

        public void dansEt()
        {
            Console.WriteLine("Insan dansEt");
        }
    }
    class Kus : Isesverebilenler
    {
        public void sesVer()
        {
            Console.WriteLine("Kus sesVer");
        }
    }

    class Piyano : Isesverebilenler
    {
        public void sesVer()
        {
            Console.WriteLine("Piyano sesVer");
        }
    }
}
