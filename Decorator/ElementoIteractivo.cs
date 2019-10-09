using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// Representa la clase base de lo que puede añadir con decoraciones
    /// </summary>
    abstract class ElementoIteractivo
    {
        public string Nombre { get; set; }

        public abstract string Render();
    }
}
