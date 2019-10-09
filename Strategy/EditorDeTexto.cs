using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class EditorDeTexto
    {
        GuardarComo g;

        public EditorDeTexto(GuardarComo inject)
        {
            g = inject;
        }

        public string TextoContenido { get; set; }

        public void GuardarTexto()
        {
            g.Guardar(TextoContenido);
        }
    }
}
