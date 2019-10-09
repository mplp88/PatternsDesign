using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Rambo r = new Rambo();
            Console.WriteLine("Rambo sin balas");
            r.Correr();
            
            r.BalasRecibidas = 1;
            Console.WriteLine("Rambo con 1 disparo");
            r.Correr();
            
            r.PoderesRecibos = 2;
            Console.WriteLine("Rambo con 1 disparo pero dos poderes");
            r.Correr();


        }
    }
}
