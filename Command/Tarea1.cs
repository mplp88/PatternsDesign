using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Tarea1: Tarea
    {
        public Tarea1(Pieza p)
            : base(p)
        { }

        public override void Ejecutar()
        {
            Console.WriteLine("Ejecutando tarea 1 con la pieza: " + miPieza.Nombre);
        }
    }
}
