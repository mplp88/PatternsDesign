using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class NodoSimple: Nodo
    {
        public override void BuscarValor(int valor)
        {
            Console.WriteLine("Lo atrapo el nodo default con id " + this.IdNodo);
        }
    }
}
