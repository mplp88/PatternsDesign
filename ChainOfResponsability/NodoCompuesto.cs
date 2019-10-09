using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class NodoCompuesto: Nodo
    {
        public Nodo Hijo { get; set; }


        public override void BuscarValor(int valor)
        {
            if (this.ValorBuscado != valor)
            {
                if (Hijo != null)
                    Hijo.BuscarValor(valor);
                else
                {
                    NodoSimple n = new NodoSimple();
                    n.IdNodo = -1;
                    n.BuscarValor(valor);
                }
            }
            else
            {
                Console.WriteLine("Lo atrapo el nodo " + this.IdNodo);
            }
        }
    }
}
