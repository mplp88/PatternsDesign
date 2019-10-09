using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{

    enum DestinoFactura
    {
        RRHH,
        Compras,
        Contabilidad
    }

    class Factura
    {
        public DateTime FechaPago { get; set; }

        public DestinoFactura Destinatario { get; set; }
    }
}
