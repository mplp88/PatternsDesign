using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class GalaxyTab: Tablet
    {

        public GalaxyTab()
        {
            base._chip = new Celular();
        }

        public void LLamar(int numero)
        {

            Console.WriteLine("\nDesde una table Galaxy...");
            base._chip.Llamar(numero);
        }

    }
}
