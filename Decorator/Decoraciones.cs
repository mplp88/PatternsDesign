using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Decoraciones: ElementoIteractivo
    {
        protected ElementoIteractivo elemento;

        public override string Render()
        {
            return elemento.Render();
        }
    }
}
