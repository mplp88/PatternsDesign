using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class NotaDeCreditoMediator:ComprobanteMediator
    {
        public NotaDeCreditoMediator(IComprobante c) : base(c) { }

        public void MostrarDestinatario()
        {
            Console.WriteLine("Mostrando destinatario de factura " + _comprobante.Numero);

        }
    }
}
