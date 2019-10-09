using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Samsung: Celular
    {
        public override void EnviarSMS(int nro)
        {
            Console.WriteLine("Desde un Samsung");
            base.EnviarSMS(nro);
        }

        public override void Llamar(int numero)
        {
            Console.WriteLine("Desde un Samsung");
            base.Llamar(numero);
        }
    }
}
