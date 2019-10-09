using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class LiquidacionesTemplate
    {
        public void LiquidarTemplateMethod()
        {
            Paso3();
            Paso2();
            Paso1();
        }

        protected abstract void Paso1();
        protected abstract void Paso2();
        protected abstract void Paso3();

    }
}
