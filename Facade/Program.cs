using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f = new Factura() {Destinatario = DestinoFactura.Contabilidad};
            
            LegacyFacade l = new LegacyFacade();

            l.CalcularFechaPago(f);
            
            Console.WriteLine("La fecha de pago de la factura para contabilidad es {0}", f.FechaPago.ToShortDateString());
            
            Console.ReadKey();

        }
    }
}
