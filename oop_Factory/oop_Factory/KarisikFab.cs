using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Factory
{
    internal class KarisikFab:IFabrika
    {
        public IPizza pizzaUret()
        {
            IPizza pizza = new KarisikPizza();
            Console.WriteLine("Karisik pizza üretildi");
            return pizza;
        }
    }
}
