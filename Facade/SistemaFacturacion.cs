using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SistemaFacturacion
    {
        private Factura f;

        public void EstablecerFechaDePago(Factura f)
        {
            switch (f.Destinatario)
            {
                case DestinoFactura.Compras:
                    f.FechaPago = DateTime.Now.AddDays(15);break;
                case DestinoFactura.Contabilidad:
                    f.FechaPago = DateTime.Now.AddDays(30);break;
                case DestinoFactura.RRHH:
                    f.FechaPago = DateTime.Now.AddDays(40);break;

            }

        }
    }
}
