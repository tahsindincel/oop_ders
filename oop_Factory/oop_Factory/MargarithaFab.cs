using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Factory
{
    internal class MargarithaFab:IFabrika
    {
        public IPizza pizzaUret()
        {
            IPizza pizza = new MargarithaPizza();
            Console.WriteLine("Margaritha uretildi");
            return pizza;
        }
    }
}
