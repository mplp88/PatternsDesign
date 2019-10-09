using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Tarea2: Tarea
    {
        public Tarea2(Pieza p)
            : base(p)
        { }

        public override void Ejecutar()
        {
            Console.WriteLine("Ejecutando tarea 2 con la pieza: " + miPieza.Nombre);
        }
    }
}
