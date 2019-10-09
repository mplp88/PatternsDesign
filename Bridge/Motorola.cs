using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Motorola: Celular
    {
        public override void Llamar(int numero)
        {
            Console.WriteLine("Desde un Motorola");
            base.Llamar(numero);
        }

        public override void EnviarSMS(int nro)
        {
            Console.WriteLine("Desde un Motorola");
            base.EnviarSMS(nro);
        }
    }
}
