using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Telefono
    {
        public virtual void Llamar(int numero)
        {
            Console.WriteLine("Llamando al número {0}", numero);

        }
    }
}
