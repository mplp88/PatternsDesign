using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite {
    class Program {
        static void Main(string[] args)
        {
            Vuelo v = new Vuelo();
            v.PrecionOriginal = 16000;

            Hotel h = new Hotel();
            h.PrecionOriginal = 2500;

            Auto a = new Auto();
            a.PrecionOriginal = 1200;

            Paquete p = new Paquete();
            p.AddItem(h);
            p.AddItem(a);
            p.AddItem(v);


            Console.WriteLine($"precio tota: {p.CalcularPrecio()}");
            Console.ReadKey();
        }
    }
}
