using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Tarea3: Tarea
    {
        public Tarea3(Pieza p)
            : base(p)
        { }

        public override void Ejecutar()
        {
            Console.WriteLine("Ejecutando tarea 3 con la pieza: " + miPieza.Nombre);
        }
    }
}
