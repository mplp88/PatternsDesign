using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class EmpresaObserver: ObservadorDeContainers
    {
        public override void AnalizarContainer(AlgoObservable container)
        {
            Container c = container as Container;
            Console.WriteLine("Esta listo el container " + c.Nro);
        }
    }
}
