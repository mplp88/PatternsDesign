using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona() { Apellido = "Lopez0", Nombre = "Jose0" };
            Persona p1 = new Persona() { Apellido = "Lopez1", Nombre = "Jose1" };
            Persona p2 = new Persona() { Apellido = "Lopez2", Nombre = "Jose2" };
            Persona p3 = new Persona() { Apellido = "Lopez3", Nombre = "Jose3" };
            Persona p4 = new Persona() { Apellido = "Lopez4", Nombre = "Jose4" };

            List<Persona> miLista = new List<Persona>();
            miLista.Add(p);
            miLista.Add(p1);
            miLista.Add(p2);
            miLista.Add(p3);
            miLista.Add(p4);

            ConcreteIterator<Persona> barraNavegacion = new ConcreteIterator<Persona>(miLista);

            //Muestro el actual
            Persona actual = barraNavegacion.CurrentItem();
            Console.WriteLine(actual.Apellido);
            Console.ReadKey();

            //Muestro el Ultimo
            barraNavegacion.MoveLast();
            actual = barraNavegacion.CurrentItem();
            Console.WriteLine(actual.Apellido);
            Console.ReadKey();

            //Muestro el anterior al ùltimo
            barraNavegacion.MovePrevious();
            actual = barraNavegacion.CurrentItem();
            Console.WriteLine(actual.Apellido);
            Console.ReadKey();

            //Muestro el anterior al primero
            barraNavegacion.MoveFirst();
            actual = barraNavegacion.CurrentItem();
            Console.WriteLine(actual.Apellido);
            Console.ReadKey();

            //Muestro el anterior al siguiente
            barraNavegacion.MoveNext();
            actual = barraNavegacion.CurrentItem();
            Console.WriteLine(actual.Apellido);
            Console.ReadKey();

        }
    }
}
