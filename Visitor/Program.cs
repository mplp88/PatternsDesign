using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Legajo l = new Legajo();
            l.Partes.Add(new ParteCV() { Nombre = "MiCV" });
            l.Partes.Add(new ParteFichaEmpleado() { Nombre = "MiFicha" });
            

            EstrategiaPDF pdf = new EstrategiaPDF();
            EstrategiaWord word = new EstrategiaWord();

            l.Abrir(pdf);
            l.Guardar(word);
            
            Console.ReadLine();



        }
    }
}
