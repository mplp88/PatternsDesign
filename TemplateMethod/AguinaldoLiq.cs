using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class AguinaldoLiq: LiquidacionesTemplate
    {
        protected override void Paso1()
        {
            Console.WriteLine("Ejecutando paso1 de aguinaldo");   
        }

        protected override void Paso2()
        {
            Console.WriteLine("Ejecutando paso2 de aguinaldo");
        }

        protected override void Paso3()
        {
            Console.WriteLine("Ejecutando paso3 de aguinaldo");
        }
    }
}
