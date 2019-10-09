using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class PedidoViewModelDirector
    {
        PedidoViewModelBuilder builder = new PedidoViewModelBuilder();
        
        public PedidoViewModel GetViewModelCompleto()
        {
            PedidoViewModel viewModel = new PedidoViewModel();

            builder.CargarParteA(viewModel);
            builder.CargarParteB(viewModel);
            builder.CargarParteC(viewModel);
            builder.CargarParteD(viewModel);

            return viewModel;

        }
        public PedidoViewModel GetViewModelParteA_D()
        {
            PedidoViewModel viewModel = new PedidoViewModel();

            builder.CargarParteA(viewModel);
            builder.CargarParteD(viewModel);

            return viewModel;
        }

        public PedidoViewModel GetViewModelParteB_C()
        {
            PedidoViewModel viewModel = new PedidoViewModel();

            builder.CargarParteB(viewModel);
            builder.CargarParteC(viewModel);

            return viewModel;
        }


    }
}
