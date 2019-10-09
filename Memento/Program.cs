using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f = new Factura();

            f.FechaEmision = DateTime.Now;
            f.Cliente = "Molinos";

            ItemFactura i1 = new ItemFactura() { Orden = 1, Descripcion = "Tornillo", Precio = 0.5m };
            ItemFactura i2 = new ItemFactura() { Orden = 1, Descripcion = "Destornillador", Precio = 1 };
            f.Items.Add(i1);
            f.Items.Add(i2);

            //Hago una copia de la cabecera de la factura
            FacturaMemento fm = f.CrearMemento();

            //Modifico la cabecera y muestro como esta
            f.Cliente = "Pirulo";
            f.FechaEmision = DateTime.Now.AddDays(-1);

            f.MostrarDatosDeFactura();

            //Restauro con el memento la cabecera y muestro como queda

            f.ReestablecerValores(fm);
            f.MostrarDatosDeFactura();

            ///////////////////////////////////////////// OTRO EJEMPLO

            Console.Clear();
            Console.WriteLine("Estos son los valores originales del objeto:");
            //Genero una copia de su estado con los valores actuales
            f.CrearMemento();
            //Muesto los valores actuales
            f.MostrarDatosDeFactura();

            Console.Clear();
            Console.WriteLine("Estos son los valores modificados del objeto:");

            //Cambio los valores
            f.Cliente = "Tenaris";
            f.FechaEmision = DateTime.Now.AddDays(5);
            //Muestro que los valores estan cambiados
            f.MostrarDatosDeFactura();

            Console.Clear();
            Console.WriteLine("Estos son los valores restaurados del objeto:");

            //Restauro la factura al valor original
            f.Restaurar();
            //Muesto que volvio al estado anterior
            f.MostrarDatosDeFactura();




            
        }
    }
}
