using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Factory
{
    internal interface IPizza
    {
        void prepare();
        void bake();
        void cut();
        void box();

    }
}
