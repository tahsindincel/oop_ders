using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFabrika pizzaFab = new MargarithaFab();
            IPizza urun1 = pizzaFab.pizzaUret();

            Console.ReadKey();
        }
    }
}
