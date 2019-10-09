using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class ObservadorDeContainers
    {
        public abstract void AnalizarContainer(AlgoObservable container);
    }
}
