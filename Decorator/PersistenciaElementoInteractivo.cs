using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class PersistenciaElementoInteractivo: Decoraciones
    {

        public PersistenciaElementoInteractivo(ElementoIteractivo elemento)
        {
            base.elemento = elemento;
            this.Nombre = elemento.Nombre;
        }

        public override string Render()
        {
            GuardarEnDB();

            return base.elemento.Render();
        }

        private void GuardarEnDB()
        {
            Console.WriteLine("Guardando en base de datos a " + base.elemento.Nombre);
        }
    }
}
