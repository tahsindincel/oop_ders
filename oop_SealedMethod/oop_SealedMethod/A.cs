using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_SealedMethod
{
    internal class A
    {
        public virtual void Metot()
        {
            Console.WriteLine("A davranışı");
        }
    }

    class B : A
    {
        public override void Metot()
        {
            Console.WriteLine("B davranışı");
        }
    }

    class C : B
    {
        public sealed override void Metot() 
        {
            Console.WriteLine("C davranışı");
        }
    }

   /* class D : C
    {
        public override void Metot()// C de sealed yaptığımız için burda override yapamıyor
        {
            Console.WriteLine("D davranışı");
        }
    }*/
}
