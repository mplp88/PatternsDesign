using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaDeCredito n = new NotaDeCredito();
            n.Destinatario = "Lopez";
            n.Numero = 11556;

            Factura f = new Factura();
            f.Importe = 9997;
            f.Numero = 2;

            NotaDeCreditoMediator nM = new NotaDeCreditoMediator(n);

            nM.MostrarDestinatario();
            nM.GuardarComprobante();

            FacturaMediator fm = new FacturaMediator(f);

            fm.CalcularImpuestos();
            fm.GuardarComprobante();

            Console.ReadKey();


        }
    }
}
