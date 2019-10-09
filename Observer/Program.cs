using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Container c = new Container();
            c.Nro = "55469";

            AFIPObserver a = new AFIPObserver();
            EmpresaObserver e = new EmpresaObserver();

            c.AgregarObservador(a);
            c.AgregarObservador(e);

            c.Arribar();
            Console.ReadKey();

        }
    }
}
