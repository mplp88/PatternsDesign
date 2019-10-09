using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class EstrategiaPDF: Visitor
    {



        public override void Guardar(Plantilla ElementoVisitado)
        {
            Console.WriteLine("Guardando el documento " + ElementoVisitado.Nombre + " en formato PDF");
        }

        public override void Abrir(Plantilla ElementoVisitado)
        {
            Console.WriteLine("Abriendo el documento " + ElementoVisitado.Nombre + " en formato PDF");
        }
    }
}
