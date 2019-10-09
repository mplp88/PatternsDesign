using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Rambo
    {
        int balas;
        int poderes;
        RamboState r;

        public Rambo()
        {
            r = new RamboNormal();
        }

        public int BalasRecibidas
        {
            get { return balas; }
            set
            {
                balas = value;
                AcomodarEstado();
            }
        }

        public int PoderesRecibos
        {
            get
            {
                return poderes;
            }

            set
            {
                poderes = value;
                AcomodarEstado();
            }
        }

        public void Correr()
        {
            r.Correr();
            Console.ReadKey();
        }

        private void AcomodarEstado()
        {

            if (balas == poderes)
                r = new RamboNormal();
            else
                if (balas > poderes)
                    r = new RamboHerido();
                else
                    r = new RamboPoderoso();
        }
    }
}
