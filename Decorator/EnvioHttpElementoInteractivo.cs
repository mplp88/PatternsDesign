using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class EnvioHttpElementoInteractivo: Decoraciones
    {
        public EnvioHttpElementoInteractivo(ElementoIteractivo e)
        {
            base.elemento = e;
        }

        public override string Render()
        {
            Console.WriteLine("Inicio de envio Http con info de {0}", base.elemento.Nombre);
            return base.elemento.Render();
        }
    }
}
