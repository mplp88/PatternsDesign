using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class GuardarPDF: GuardarComo
    {
        public override void Guardar(string texto)
        {
            Console.WriteLine("El texto:" + texto);
            Console.WriteLine("Guardado en formato PDF");
        }
    }
}
