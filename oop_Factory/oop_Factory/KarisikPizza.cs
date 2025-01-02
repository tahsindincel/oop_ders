using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Factory
{
    internal class KarisikPizza:IPizza
    {
        public void prepare()
        {
            Console.WriteLine("Karışık hazırlanıyor");
        }

        public void bake()
        {
            Console.WriteLine("Karışık pişiyor");
        }

        public void cut()
        {
            Console.WriteLine("Karışık dilimleniyor");
        }

        public void box()
        {
            Console.WriteLine("Karışık kutuya konuluyor");
        }
    }
}
