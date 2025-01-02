using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Adapter
{
    internal class Adaptor:UcluPriz
    {
        public override void ucUcuBagla()
        {
            IkiliPriz priz = new IkiliPriz();
            priz.ikiUcBagla();
        }
    }
}
