using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Legajo
    {        

        public Legajo()
        {
            
            Partes = new List<Plantilla>();
        }


        public List<Plantilla> Partes { get; set; }

        public void Abrir(Visitor visitante)
        {            
            foreach (var parte in Partes)
            {
                parte.Abrir(visitante);
            }
        }

        public void Guardar(Visitor visitante)
        {
            foreach (var parte in Partes)
            {
                parte.Guardar(visitante);
            }
        }

        
    }
}
