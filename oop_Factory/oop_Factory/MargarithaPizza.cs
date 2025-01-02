using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Factory
{
    internal class MargarithaPizza:IPizza
    {
        public void prepare()
        {
            Console.WriteLine("Margaritha hazırlanıyor");
        }

        public void bake()
        {
            Console.WriteLine("Margaritha pişiyor");
        }

        public void cut()
        {
            Console.WriteLine("Margaritha dilimleniyor");
        }

        public void box()
        {
            Console.WriteLine("Margaritha kutuya konuluyor");
        }
    }
}
