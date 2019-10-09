using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Container: AlgoObservable
    {
        public string Nro { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }

        public void Arribar()
        {
            Console.WriteLine("Arribo el container " + Nro);
            Notificar();
        }

        
    }
}
