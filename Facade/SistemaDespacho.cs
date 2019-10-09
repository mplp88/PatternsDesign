using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SistemaDespacho
    {
        public void PlanificarDespacho(DateTime fecha)
        {
            Console.WriteLine("Planificando despacho para la fecha {0}", fecha.ToShortDateString());
        }
    }
}
