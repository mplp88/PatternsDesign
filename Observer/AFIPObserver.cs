using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class AFIPObserver: ObservadorDeContainers
    {
        public override void AnalizarContainer(AlgoObservable container)
        {
            Container c = container as Container;
            Console.WriteLine("Estamos revisando el container " + c.Nro);
        }
    }
}
