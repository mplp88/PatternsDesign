using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class RamboHerido: RamboState
    {
        public override void Correr()
        {
            Console.WriteLine("Corriendo despacito...");
        }
    }
}
