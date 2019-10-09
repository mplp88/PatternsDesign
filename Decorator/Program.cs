using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ElementoIteractivo p = new PersonajeBueno("Mario Bross");

            ElementoIteractivo pei = new PersistenciaElementoInteractivo(p);

            ElementoIteractivo envio = new EnvioHttpElementoInteractivo(pei);

            Console.WriteLine(envio.Render());

            Console.ReadKey();
            
        }
    }
}
