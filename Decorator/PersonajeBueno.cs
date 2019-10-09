using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class PersonajeBueno: ElementoIteractivo
    {
        public PersonajeBueno(string nombre)
        {
            this.Nombre = nombre;
        }

        public override string Render()
        {
            return "Renderizando a " + this.Nombre;
        }
    }
}
