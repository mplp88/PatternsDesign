using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    abstract class Tarea
    {
        protected Pieza miPieza;

        public Tarea(Pieza p){
            miPieza  = p;
        }

        public abstract void Ejecutar();
    }
}
