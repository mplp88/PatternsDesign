using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona pe1 = new Persona();
            pe1.Apellido = "Lopez";
            pe1.Nombre = "Jose";

            Persona pe2 = pe1.Clone();
            pe2.Nombre = "Alberto";

            Persona pe3 = pe1;

            pe1.Nombre = "Juan";

            Console.WriteLine($"Nombre de persona1: {pe1.Nombre} , nombre de persona 2 { pe2.Nombre} y nombre de persona 3 { pe3.Nombre}");
            Console.ReadKey();
        }
    }
}
