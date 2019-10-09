using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Celular: Telefono
    {
        public virtual void EnviarSMS(int nro)
        {
            Console.WriteLine("Enviando SMS al número {0}", nro);
        }
    }
}
