using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class LegacyFacade
    {
        SistemaFacturacion s = new SistemaFacturacion();
        SistemaDespacho d = new SistemaDespacho();

        public DateTime CalcularFechaPago(Factura f)
        {
            
            s.EstablecerFechaDePago(f);
            d.PlanificarDespacho(f.FechaPago);

            return f.FechaPago;
        }
    }
}
