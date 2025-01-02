using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UcluPriz priz = new Adaptor();
            priz.ucUcuBagla();


            Console.ReadKey();
        }
    }
}
