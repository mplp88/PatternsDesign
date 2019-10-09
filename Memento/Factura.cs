using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Factura
    {
        FacturaMemento ultimoEstadoCopiado;
        
        public DateTime FechaEmision { get; set; }
        public string Cliente { get; set; }

        public List<ItemFactura> Items { get; set; }

        public Factura()
        {
            Items = new List<ItemFactura>();
        }

        public FacturaMemento CrearMemento()
        {
            FacturaMemento f = new FacturaMemento() { FechaEmision = FechaEmision, Cliente = Cliente};
            ultimoEstadoCopiado = f;
            return f;
        }

        public void ReestablecerValores(FacturaMemento f)
        {
            FechaEmision = f.FechaEmision;
            Cliente = f.Cliente;
        }

        public void MostrarDatosDeFactura()
        {
            Console.WriteLine("La factura tiene {0} elementos", Items.Count);
            Console.WriteLine("La fecha de emision es {0}", FechaEmision.ToShortDateString());
            Console.WriteLine("La cliente es {0}", Cliente);
            Console.ReadKey();
        }

        public void Restaurar()
        {
            ReestablecerValores(ultimoEstadoCopiado);
        }



    }
}
