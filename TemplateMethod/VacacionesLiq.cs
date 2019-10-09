using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class VacacionesLiq: LiquidacionesTemplate
    {
        protected override void Paso1()
        {
            Console.WriteLine("Ejecutando paso1 de vacaciones");
        }

        protected override void Paso2()
        {
            Console.WriteLine("Ejecutando paso2 de vacaciones");
        }

        protected override void Paso3()
        {
            Console.WriteLine("Ejecutando paso3 de vacaciones");
        }
    }
}
