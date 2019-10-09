using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class PedidoViewModelBuilder
    {
        public void CargarParteA(PedidoViewModel par1)
        {
            par1.Parte_A = "Completado contenido parte A";
        }

        public void CargarParteB(PedidoViewModel par1)
        {
            par1.Parte_B = "Completado contenido parte B";
        }

        public void CargarParteC(PedidoViewModel par1)
        {
            par1.Parte_C = "Completado contenido parte C";
        }

        public void CargarParteD(PedidoViewModel par1)
        {
            par1.Parte_D = "Completado contenido parte D";
        }
    }
}
