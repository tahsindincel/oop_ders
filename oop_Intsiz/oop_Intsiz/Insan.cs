using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Intsiz
{
    internal class Insan:sesVerenler
    {
        public override void sesVer()
        {
            Console.WriteLine("insan gibi ses verdi");
        }

        //insanın dans etmesini de istiyoruz ama interface kullanmadan bunu yapamıyoruz. çünkü 2 yerden kalıtım olmuyor.
    }
}
