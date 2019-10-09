using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Pieza p = new Pieza();
            p.Nombre = "Tornillo";

            Tarea1 t1 = new Tarea1(p);
            Tarea2 t2 = new Tarea2(p);
            Tarea3 t3 = new Tarea3(p);

            LineaDeMontaje l = new LineaDeMontaje();
            l.AgregarTarea(t3);
            l.AgregarTarea(t1);
            l.AgregarTarea(t2);

            l.IniciarProceso();
            Console.ReadKey();

            
        }
    }
}
