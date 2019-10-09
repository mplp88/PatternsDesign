using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    abstract class Nodo
    {
        public int ValorBuscado { get; set; }
        public int IdNodo { get; set; }

        public abstract void BuscarValor(int valor);
    }
}
