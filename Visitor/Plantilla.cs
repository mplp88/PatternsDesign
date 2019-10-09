using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class Plantilla
    {       

        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }

        public void Abrir(Visitor v)
        {            
            v.Abrir(this);            
        }

        public void Guardar(Visitor v)
        {
            v.Guardar(this);
        }

    }
}
