using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            PedidoViewModelDirector director = new PedidoViewModelDirector();

            PedidoViewModel viewModel = director.GetViewModelCompleto();

            viewModel = director.GetViewModelParteA_D();

            viewModel = director.GetViewModelParteB_C();

            Console.ReadKey();
        }
    }
}
