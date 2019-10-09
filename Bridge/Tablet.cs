using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Tablet
    {
        protected Celular _chip;

        public void NavegarPorInternet()
        {
            Console.WriteLine("Navegando por internet");
        }
    }
}
