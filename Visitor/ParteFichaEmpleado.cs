using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ParteFichaEmpleado: Plantilla
    {
        public DateTime FechaIngreso { get; set; }
        public string Gerencia { get; set; }
    }
}
