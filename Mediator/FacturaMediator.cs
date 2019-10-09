using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class FacturaMediator: ComprobanteMediator
    {

        public FacturaMediator(IComprobante c) : base(c) { }
        

        public void CalcularImpuestos()
        {
            Console.WriteLine("calculando impuestos de factura " + _comprobante.Numero);
        }
    }
}
