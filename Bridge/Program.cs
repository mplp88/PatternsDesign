using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {

            //Puedo usar 
            Samsung s = new Samsung();
            s.Llamar(1166547354);

            GalaxyTab g = new GalaxyTab();
            g.LLamar(1166543276);

            //El Ipad no puede hacer llamadas por chip...sin embargo es una tablet.
            Ipad i = new Ipad();
            i.ConectarConMacBook();

            Console.ReadKey();

        }
    }
}
