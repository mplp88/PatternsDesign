using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Los Ipad no tienen lugar para chip SIM, por lo tanto no puede llamar...sin embargo es una tablet igual.
    /// </summary>
    class Ipad: Tablet
    {

        public void ConectarConMacBook()
        {
            Console.WriteLine("\nConectando con una MacBook");
        }
    }
}
