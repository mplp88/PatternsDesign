using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class ComprobanteMediator
    {
        protected IComprobante _comprobante;

        public ComprobanteMediator(IComprobante c)
        {
            _comprobante = c;
        }

        public void GuardarComprobante()
        {
            Console.WriteLine("Guardando comprobante");
        }
    }
}
