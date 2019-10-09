using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Factura: IComprobante
    {
        public int Numero {get;set;}
        public int Importe { get; set; }

    }
}
